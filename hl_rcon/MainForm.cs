using System;
using System.Windows.Forms;
using System.IO;
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

        /* <========= TAB 1 <=========> */
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

        private void tab1_button3_Click(object sender, EventArgs e)
        {
            string reply = SendRconCommand("jk_botti bot_add_level_tag");
            if (reply == null && !reply.StartsWith("[jk_botti]"))
                return;
            bool flag = reply.Contains("is on");
            SendRconCommand("jk_botti bot_add_level_tag " + (flag ? "0" : "1"));
            tab1_label2.Text = "level_tag: " + (flag ? "off" : "on");

        }
    }
}

