using System;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace hl_rcon
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // load settings
            string PATH_SETTINGS = Path.Combine(Environment.CurrentDirectory, "settings.txt");

            if (File.Exists(PATH_SETTINGS))
            {
                string[] file = File.ReadAllLines(PATH_SETTINGS);

                if (file.Length >= 1)
                    textBoxAdress.Text = file[0];
                if (file.Length >= 2)
                    textBoxPassword.Text = file[1];
            }
        }

        private string SendRconCommand(string command, bool suppress = false)
        {
            if (string.IsNullOrEmpty(textBoxPassword.Text))
            {
                if(!suppress)
                    MessageBox.Show("Musisz wpisać hasło do RCON!", "RCON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            if (string.IsNullOrEmpty(textBoxAdress.Text))
            {
                MessageBox.Show("Musisz podać prawidłowy adres!", "RCON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            string address;
            int port = 27015;
            string[] split = textBoxAdress.Text.Split(':');
            switch (split.Length)
            {
                case 1:
                    address = textBoxAdress.Text;
                    break;

                case 2:
                    address = split[0];
                    port = int.Parse(split[1]);
                    break;

                default:
                    MessageBox.Show("Musisz podać prawidłowy adres!\nNieprawidłowy format", "RCON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
            }

            if (command.StartsWith("rcon "))
                command = command.Substring(5, command.Length - 5);

            return Rcon.SendRconMessage(new Server() 
            { 
                Address = address, 
                Port = port, 
                RconPassword = textBoxPassword.Text 
            }, command);
        }

        private string BoolToString(bool value, bool invert = false) => (!invert) ? ((value) ? "1" : "0") : ((value) ? "0" : "1");
        private void buttonSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCommand.Text))
            {
                MessageBox.Show("Musisz podać komende!", "RCON Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxCommand.Text.StartsWith("rcon "))
            {
                textBoxCommand.Text = textBoxCommand.Text.Substring(5, textBoxCommand.Text.Length - 5);
            }

            try
            {
                textBoxConsole.Text = SendRconCommand(textBoxCommand.Text);

                if (clearCommand.Checked)
                    textBoxCommand.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "RCON Erorr", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* <=========> TAB 1 <=========> */

        private void tab1_button1_Click(object sender, EventArgs e)
        {
            SendRconCommand($"jk_botti max_bots {tab1_numericUpDown1.Value}");
            SendRconCommand($"jk_botti min_bots {tab1_numericUpDown1.Value}", true);
        }

        private void tab1_button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < tab1_numericUpDown2.Value; i++)
                SendRconCommand($"jk_botti addbot");
        }

        private void tab1_SendAndHandleRconCommand(string command, string reply_key, string label_text)
        {
            string reply = SendRconCommand(command);
            if (reply == null && !reply.StartsWith("[jk_botti]"))
                return;
            bool flag = reply.Contains(reply_key);
            SendRconCommand(command + " " + (flag ? "0" : "1"));
            tab1_label2.Text = label_text + ": " + (flag ? "off" : "on");
        }
        private void tab1_button3_Click(object sender, EventArgs e)
        {
            tab1_SendAndHandleRconCommand("jk_botti bot_add_level_tag", "is on", "level_tag");
        }

        private void tab1_button4_Click(object sender, EventArgs e)
        {
            tab1_SendAndHandleRconCommand("jk_botti random_color", "ENABLED", "random_color");
        }

        private void tab1_button5_Click(object sender, EventArgs e)
        {
            tab1_SendAndHandleRconCommand("jk_botti randomize_bots_on_mapchange", "is on", "random_bots");
        }

        /* <=========> TAB 2 <=========> */
        private class tab2_Command
        {
            public string command, value;
            public tab2_Command(string command, string value)
            {
                this.command = command;
                this.value = value;
            }

            public int IntValue() => (!String.IsNullOrEmpty(value)) ? Convert.ToInt32(value) : 0;

            public decimal DecimalValue() => (!String.IsNullOrEmpty(value)) ? Convert.ToDecimal(value) : 0;

        }

        Regex tab2_REGEX = new Regex("(?<=\")[\\w]+(?!=\")");

        private tab2_Command tab2_SendAndHandleRconCommand(string command)
        {
            string reply = SendRconCommand(command);

            if (!reply.Contains(" is "))
                return null;

            MatchCollection matches = tab2_REGEX.Matches(reply);

            if (matches.Count != 2)
                return null;
            
            return new tab2_Command(matches[0].Value,matches[1].Value);
        }

        private void tab2_button1_Click(object sender, EventArgs e)
        {
            SendRconCommand("sv_gravity " + tab2_numericUpDown1.Value);
        }

        private void tab2_button2_Click(object sender, EventArgs e)
        {
            tab2_numericUpDown1.Value = tab2_SendAndHandleRconCommand("sv_gravity").DecimalValue();
        }

        private void tab2_checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SendRconCommand("sv_cheats " + BoolToString(tab2_checkBox1.Checked));
        }

        private void tab2_checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            SendRconCommand("mp_flashlight " + BoolToString(tab2_checkBox2.Checked));
        }
    }
}

