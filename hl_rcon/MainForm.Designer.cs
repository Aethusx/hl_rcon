namespace hl_rcon
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxRconConsole = new System.Windows.Forms.GroupBox();
            this.clearCommand = new System.Windows.Forms.CheckBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.textBoxConsole = new System.Windows.Forms.RichTextBox();
            this.groupBoxServer = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAdress = new System.Windows.Forms.MaskedTextBox();
            this.textBoxPassword = new System.Windows.Forms.MaskedTextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainTab = new System.Windows.Forms.TabPage();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tab1_groupBox3 = new System.Windows.Forms.GroupBox();
            this.tab1_button3 = new System.Windows.Forms.Button();
            this.tab1_label2 = new System.Windows.Forms.Label();
            this.tab1_groupBox2 = new System.Windows.Forms.GroupBox();
            this.tab1_button2 = new System.Windows.Forms.Button();
            this.tab1_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tab1_groupBox1 = new System.Windows.Forms.GroupBox();
            this.tab1_button1 = new System.Windows.Forms.Button();
            this.tab1_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tab1_button4 = new System.Windows.Forms.Button();
            this.tab1_button5 = new System.Windows.Forms.Button();
            this.tab2 = new System.Windows.Forms.TabPage();
            this.tab2_groupBox1 = new System.Windows.Forms.GroupBox();
            this.tab2_numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tab2_button1 = new System.Windows.Forms.Button();
            this.tab2_button2 = new System.Windows.Forms.Button();
            this.tab2_groupBox2 = new System.Windows.Forms.GroupBox();
            this.tab2_checkBox1 = new System.Windows.Forms.CheckBox();
            this.tab2_checkBox2 = new System.Windows.Forms.CheckBox();
            this.tab2_checkBox3 = new System.Windows.Forms.CheckBox();
            this.tab2_button3 = new System.Windows.Forms.Button();
            this.tab2_groupBox3 = new System.Windows.Forms.GroupBox();
            this.tab2_button5 = new System.Windows.Forms.Button();
            this.tab2_button4 = new System.Windows.Forms.Button();
            this.tab2_numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.tab2_groupBox4 = new System.Windows.Forms.GroupBox();
            this.tab2_comboBox1 = new System.Windows.Forms.ComboBox();
            this.tab2_button6 = new System.Windows.Forms.Button();
            this.tab2_button7 = new System.Windows.Forms.Button();
            this.tab2_checkBox4 = new System.Windows.Forms.CheckBox();
            this.tab3 = new System.Windows.Forms.TabPage();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.groupBoxRconConsole.SuspendLayout();
            this.groupBoxServer.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.mainTab.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tab1_groupBox3.SuspendLayout();
            this.tab1_groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_numericUpDown2)).BeginInit();
            this.tab1_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab1_numericUpDown1)).BeginInit();
            this.tab2.SuspendLayout();
            this.tab2_groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_numericUpDown1)).BeginInit();
            this.tab2_groupBox2.SuspendLayout();
            this.tab2_groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tab2_numericUpDown2)).BeginInit();
            this.tab2_groupBox4.SuspendLayout();
            this.tab3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxRconConsole
            // 
            this.groupBoxRconConsole.Controls.Add(this.clearCommand);
            this.groupBoxRconConsole.Controls.Add(this.buttonSend);
            this.groupBoxRconConsole.Controls.Add(this.textBoxCommand);
            this.groupBoxRconConsole.Controls.Add(this.labelInfo);
            this.groupBoxRconConsole.Controls.Add(this.textBoxConsole);
            this.groupBoxRconConsole.Location = new System.Drawing.Point(8, 80);
            this.groupBoxRconConsole.Name = "groupBoxRconConsole";
            this.groupBoxRconConsole.Size = new System.Drawing.Size(365, 252);
            this.groupBoxRconConsole.TabIndex = 3;
            this.groupBoxRconConsole.TabStop = false;
            this.groupBoxRconConsole.Text = "RCON Konsola";
            // 
            // clearCommand
            // 
            this.clearCommand.AutoSize = true;
            this.clearCommand.Checked = true;
            this.clearCommand.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clearCommand.Location = new System.Drawing.Point(263, 225);
            this.clearCommand.Name = "clearCommand";
            this.clearCommand.Size = new System.Drawing.Size(15, 14);
            this.clearCommand.TabIndex = 6;
            this.clearCommand.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(284, 221);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 21);
            this.buttonSend.TabIndex = 4;
            this.buttonSend.Text = "Wyslij";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Location = new System.Drawing.Point(69, 221);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(188, 20);
            this.textBoxCommand.TabIndex = 3;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(8, 224);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(55, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Komenda:";
            // 
            // textBoxConsole
            // 
            this.textBoxConsole.Location = new System.Drawing.Point(9, 19);
            this.textBoxConsole.Name = "textBoxConsole";
            this.textBoxConsole.ReadOnly = true;
            this.textBoxConsole.Size = new System.Drawing.Size(350, 195);
            this.textBoxConsole.TabIndex = 5;
            this.textBoxConsole.Text = "";
            // 
            // groupBoxServer
            // 
            this.groupBoxServer.Controls.Add(this.label1);
            this.groupBoxServer.Controls.Add(this.textBoxAdress);
            this.groupBoxServer.Controls.Add(this.textBoxPassword);
            this.groupBoxServer.Controls.Add(this.labelPassword);
            this.groupBoxServer.Location = new System.Drawing.Point(6, 6);
            this.groupBoxServer.Name = "groupBoxServer";
            this.groupBoxServer.Size = new System.Drawing.Size(367, 68);
            this.groupBoxServer.TabIndex = 2;
            this.groupBoxServer.TabStop = false;
            this.groupBoxServer.Text = "Dane logowania";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Adres:";
            // 
            // textBoxAdress
            // 
            this.textBoxAdress.Location = new System.Drawing.Point(85, 16);
            this.textBoxAdress.Name = "textBoxAdress";
            this.textBoxAdress.Size = new System.Drawing.Size(276, 20);
            this.textBoxAdress.TabIndex = 5;
            this.textBoxAdress.ValidatingType = typeof(int);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(85, 42);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(276, 20);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.ValidatingType = typeof(int);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(8, 45);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(73, 13);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "RCON Hasło:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainTab);
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tab2);
            this.tabControl1.Controls.Add(this.tab3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(387, 364);
            this.tabControl1.TabIndex = 7;
            // 
            // mainTab
            // 
            this.mainTab.Controls.Add(this.groupBoxServer);
            this.mainTab.Controls.Add(this.groupBoxRconConsole);
            this.mainTab.Location = new System.Drawing.Point(4, 22);
            this.mainTab.Name = "mainTab";
            this.mainTab.Padding = new System.Windows.Forms.Padding(3);
            this.mainTab.Size = new System.Drawing.Size(379, 338);
            this.mainTab.TabIndex = 0;
            this.mainTab.Text = "Główne";
            this.mainTab.UseVisualStyleBackColor = true;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.tab1_groupBox3);
            this.tab1.Controls.Add(this.tab1_groupBox2);
            this.tab1.Controls.Add(this.tab1_groupBox1);
            this.tab1.Location = new System.Drawing.Point(4, 22);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(379, 338);
            this.tab1.TabIndex = 1;
            this.tab1.Text = "jk_botti";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tab1_groupBox3
            // 
            this.tab1_groupBox3.Controls.Add(this.tab1_button5);
            this.tab1_groupBox3.Controls.Add(this.tab1_button4);
            this.tab1_groupBox3.Controls.Add(this.tab1_button3);
            this.tab1_groupBox3.Controls.Add(this.tab1_label2);
            this.tab1_groupBox3.Location = new System.Drawing.Point(185, 6);
            this.tab1_groupBox3.Name = "tab1_groupBox3";
            this.tab1_groupBox3.Size = new System.Drawing.Size(186, 131);
            this.tab1_groupBox3.TabIndex = 3;
            this.tab1_groupBox3.TabStop = false;
            this.tab1_groupBox3.Text = "Przerozne opcje";
            // 
            // tab1_button3
            // 
            this.tab1_button3.Location = new System.Drawing.Point(9, 19);
            this.tab1_button3.Name = "tab1_button3";
            this.tab1_button3.Size = new System.Drawing.Size(171, 23);
            this.tab1_button3.TabIndex = 2;
            this.tab1_button3.Text = "Level Tag przy nicku botów";
            this.tab1_button3.UseVisualStyleBackColor = true;
            this.tab1_button3.Click += new System.EventHandler(this.tab1_button3_Click);
            // 
            // tab1_label2
            // 
            this.tab1_label2.AutoSize = true;
            this.tab1_label2.Location = new System.Drawing.Point(6, 103);
            this.tab1_label2.Name = "tab1_label2";
            this.tab1_label2.Size = new System.Drawing.Size(16, 13);
            this.tab1_label2.TabIndex = 0;
            this.tab1_label2.Text = "...";
            // 
            // tab1_groupBox2
            // 
            this.tab1_groupBox2.Controls.Add(this.tab1_button2);
            this.tab1_groupBox2.Controls.Add(this.tab1_numericUpDown2);
            this.tab1_groupBox2.Location = new System.Drawing.Point(8, 62);
            this.tab1_groupBox2.Name = "tab1_groupBox2";
            this.tab1_groupBox2.Size = new System.Drawing.Size(171, 50);
            this.tab1_groupBox2.TabIndex = 2;
            this.tab1_groupBox2.TabStop = false;
            this.tab1_groupBox2.Text = "Dodaj boty manualnie";
            // 
            // tab1_button2
            // 
            this.tab1_button2.Location = new System.Drawing.Point(132, 19);
            this.tab1_button2.Name = "tab1_button2";
            this.tab1_button2.Size = new System.Drawing.Size(33, 20);
            this.tab1_button2.TabIndex = 1;
            this.tab1_button2.Text = "OK";
            this.tab1_button2.UseVisualStyleBackColor = true;
            this.tab1_button2.Click += new System.EventHandler(this.tab1_button2_Click);
            // 
            // tab1_numericUpDown2
            // 
            this.tab1_numericUpDown2.Location = new System.Drawing.Point(6, 19);
            this.tab1_numericUpDown2.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tab1_numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.tab1_numericUpDown2.Name = "tab1_numericUpDown2";
            this.tab1_numericUpDown2.Size = new System.Drawing.Size(120, 20);
            this.tab1_numericUpDown2.TabIndex = 0;
            this.tab1_numericUpDown2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tab1_groupBox1
            // 
            this.tab1_groupBox1.Controls.Add(this.tab1_button1);
            this.tab1_groupBox1.Controls.Add(this.tab1_numericUpDown1);
            this.tab1_groupBox1.Location = new System.Drawing.Point(8, 6);
            this.tab1_groupBox1.Name = "tab1_groupBox1";
            this.tab1_groupBox1.Size = new System.Drawing.Size(171, 50);
            this.tab1_groupBox1.TabIndex = 0;
            this.tab1_groupBox1.TabStop = false;
            this.tab1_groupBox1.Text = "Ilość botów (min && max)";
            // 
            // tab1_button1
            // 
            this.tab1_button1.Location = new System.Drawing.Point(132, 19);
            this.tab1_button1.Name = "tab1_button1";
            this.tab1_button1.Size = new System.Drawing.Size(33, 20);
            this.tab1_button1.TabIndex = 1;
            this.tab1_button1.Text = "OK";
            this.tab1_button1.UseVisualStyleBackColor = true;
            this.tab1_button1.Click += new System.EventHandler(this.tab1_button1_Click);
            // 
            // tab1_numericUpDown1
            // 
            this.tab1_numericUpDown1.Location = new System.Drawing.Point(6, 19);
            this.tab1_numericUpDown1.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.tab1_numericUpDown1.Name = "tab1_numericUpDown1";
            this.tab1_numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.tab1_numericUpDown1.TabIndex = 0;
            // 
            // tab1_button4
            // 
            this.tab1_button4.Location = new System.Drawing.Point(9, 48);
            this.tab1_button4.Name = "tab1_button4";
            this.tab1_button4.Size = new System.Drawing.Size(171, 23);
            this.tab1_button4.TabIndex = 3;
            this.tab1_button4.Text = "Losowy kolor";
            this.tab1_button4.UseVisualStyleBackColor = true;
            this.tab1_button4.Click += new System.EventHandler(this.tab1_button4_Click);
            // 
            // tab1_button5
            // 
            this.tab1_button5.Location = new System.Drawing.Point(9, 77);
            this.tab1_button5.Name = "tab1_button5";
            this.tab1_button5.Size = new System.Drawing.Size(171, 23);
            this.tab1_button5.TabIndex = 4;
            this.tab1_button5.Text = "Losowe boty przy zmianie mapy";
            this.tab1_button5.UseVisualStyleBackColor = true;
            this.tab1_button5.Click += new System.EventHandler(this.tab1_button5_Click);
            // 
            // tab2
            // 
            this.tab2.Controls.Add(this.tab2_groupBox4);
            this.tab2.Controls.Add(this.tab2_groupBox3);
            this.tab2.Controls.Add(this.tab2_groupBox2);
            this.tab2.Controls.Add(this.tab2_groupBox1);
            this.tab2.Location = new System.Drawing.Point(4, 22);
            this.tab2.Name = "tab2";
            this.tab2.Size = new System.Drawing.Size(379, 338);
            this.tab2.TabIndex = 2;
            this.tab2.Text = "Opcje Serwera";
            this.tab2.UseVisualStyleBackColor = true;
            // 
            // tab2_groupBox1
            // 
            this.tab2_groupBox1.Controls.Add(this.tab2_button2);
            this.tab2_groupBox1.Controls.Add(this.tab2_button1);
            this.tab2_groupBox1.Controls.Add(this.tab2_numericUpDown1);
            this.tab2_groupBox1.Location = new System.Drawing.Point(8, 6);
            this.tab2_groupBox1.Name = "tab2_groupBox1";
            this.tab2_groupBox1.Size = new System.Drawing.Size(157, 52);
            this.tab2_groupBox1.TabIndex = 0;
            this.tab2_groupBox1.TabStop = false;
            this.tab2_groupBox1.Text = "Grawitacja (sv_gravity)";
            // 
            // tab2_numericUpDown1
            // 
            this.tab2_numericUpDown1.Location = new System.Drawing.Point(6, 19);
            this.tab2_numericUpDown1.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tab2_numericUpDown1.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.tab2_numericUpDown1.Name = "tab2_numericUpDown1";
            this.tab2_numericUpDown1.Size = new System.Drawing.Size(70, 20);
            this.tab2_numericUpDown1.TabIndex = 0;
            // 
            // tab2_button1
            // 
            this.tab2_button1.Location = new System.Drawing.Point(82, 19);
            this.tab2_button1.Name = "tab2_button1";
            this.tab2_button1.Size = new System.Drawing.Size(31, 20);
            this.tab2_button1.TabIndex = 1;
            this.tab2_button1.Text = "Ok";
            this.tab2_button1.UseVisualStyleBackColor = true;
            this.tab2_button1.Click += new System.EventHandler(this.tab2_button1_Click);
            // 
            // tab2_button2
            // 
            this.tab2_button2.Location = new System.Drawing.Point(116, 19);
            this.tab2_button2.Name = "tab2_button2";
            this.tab2_button2.Size = new System.Drawing.Size(31, 20);
            this.tab2_button2.TabIndex = 2;
            this.tab2_button2.Text = "S";
            this.tab2_button2.UseVisualStyleBackColor = true;
            this.tab2_button2.Click += new System.EventHandler(this.tab2_button2_Click);
            // 
            // tab2_groupBox2
            // 
            this.tab2_groupBox2.Controls.Add(this.tab2_checkBox4);
            this.tab2_groupBox2.Controls.Add(this.tab2_button3);
            this.tab2_groupBox2.Controls.Add(this.tab2_checkBox3);
            this.tab2_groupBox2.Controls.Add(this.tab2_checkBox2);
            this.tab2_groupBox2.Controls.Add(this.tab2_checkBox1);
            this.tab2_groupBox2.Location = new System.Drawing.Point(176, 6);
            this.tab2_groupBox2.Name = "tab2_groupBox2";
            this.tab2_groupBox2.Size = new System.Drawing.Size(195, 146);
            this.tab2_groupBox2.TabIndex = 1;
            this.tab2_groupBox2.TabStop = false;
            this.tab2_groupBox2.Text = "Opcje";
            // 
            // tab2_checkBox1
            // 
            this.tab2_checkBox1.AutoSize = true;
            this.tab2_checkBox1.Location = new System.Drawing.Point(6, 19);
            this.tab2_checkBox1.Name = "tab2_checkBox1";
            this.tab2_checkBox1.Size = new System.Drawing.Size(163, 17);
            this.tab2_checkBox1.TabIndex = 0;
            this.tab2_checkBox1.Text = "sv_cheats (uzywanie kodów)";
            this.tab2_checkBox1.UseVisualStyleBackColor = true;
            this.tab2_checkBox1.CheckedChanged += new System.EventHandler(this.tab2_checkBox1_CheckedChanged);
            // 
            // tab2_checkBox2
            // 
            this.tab2_checkBox2.AutoSize = true;
            this.tab2_checkBox2.Location = new System.Drawing.Point(6, 42);
            this.tab2_checkBox2.Name = "tab2_checkBox2";
            this.tab2_checkBox2.Size = new System.Drawing.Size(171, 17);
            this.tab2_checkBox2.TabIndex = 1;
            this.tab2_checkBox2.Text = "mp_flashlight (uzywanie latarki)";
            this.tab2_checkBox2.UseVisualStyleBackColor = true;
            this.tab2_checkBox2.CheckedChanged += new System.EventHandler(this.tab2_checkBox2_CheckedChanged);
            // 
            // tab2_checkBox3
            // 
            this.tab2_checkBox3.AutoSize = true;
            this.tab2_checkBox3.Location = new System.Drawing.Point(6, 65);
            this.tab2_checkBox3.Name = "tab2_checkBox3";
            this.tab2_checkBox3.Size = new System.Drawing.Size(160, 17);
            this.tab2_checkBox3.TabIndex = 2;
            this.tab2_checkBox3.Text = "mp_footsteps (slychac kroki)";
            this.tab2_checkBox3.UseVisualStyleBackColor = true;
            this.tab2_checkBox3.CheckedChanged += new System.EventHandler(this.tab2_checkBox3_CheckedChanged);
            // 
            // tab2_button3
            // 
            this.tab2_button3.Location = new System.Drawing.Point(6, 111);
            this.tab2_button3.Name = "tab2_button3";
            this.tab2_button3.Size = new System.Drawing.Size(183, 23);
            this.tab2_button3.TabIndex = 3;
            this.tab2_button3.Text = "Sync";
            this.tab2_button3.UseVisualStyleBackColor = true;
            this.tab2_button3.Click += new System.EventHandler(this.tab2_button3_Click);
            // 
            // tab2_groupBox3
            // 
            this.tab2_groupBox3.Controls.Add(this.tab2_button5);
            this.tab2_groupBox3.Controls.Add(this.tab2_button4);
            this.tab2_groupBox3.Controls.Add(this.tab2_numericUpDown2);
            this.tab2_groupBox3.Location = new System.Drawing.Point(8, 64);
            this.tab2_groupBox3.Name = "tab2_groupBox3";
            this.tab2_groupBox3.Size = new System.Drawing.Size(157, 52);
            this.tab2_groupBox3.TabIndex = 3;
            this.tab2_groupBox3.TabStop = false;
            this.tab2_groupBox3.Text = "Maks. prędkość (maxspeed)";
            // 
            // tab2_button5
            // 
            this.tab2_button5.Location = new System.Drawing.Point(116, 19);
            this.tab2_button5.Name = "tab2_button5";
            this.tab2_button5.Size = new System.Drawing.Size(31, 20);
            this.tab2_button5.TabIndex = 2;
            this.tab2_button5.Text = "S";
            this.tab2_button5.UseVisualStyleBackColor = true;
            this.tab2_button5.Click += new System.EventHandler(this.tab2_button5_Click);
            // 
            // tab2_button4
            // 
            this.tab2_button4.Location = new System.Drawing.Point(82, 19);
            this.tab2_button4.Name = "tab2_button4";
            this.tab2_button4.Size = new System.Drawing.Size(31, 20);
            this.tab2_button4.TabIndex = 1;
            this.tab2_button4.Text = "Ok";
            this.tab2_button4.UseVisualStyleBackColor = true;
            this.tab2_button4.Click += new System.EventHandler(this.tab2_button4_Click);
            // 
            // tab2_numericUpDown2
            // 
            this.tab2_numericUpDown2.Location = new System.Drawing.Point(6, 19);
            this.tab2_numericUpDown2.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.tab2_numericUpDown2.Name = "tab2_numericUpDown2";
            this.tab2_numericUpDown2.Size = new System.Drawing.Size(70, 20);
            this.tab2_numericUpDown2.TabIndex = 0;
            // 
            // tab2_groupBox4
            // 
            this.tab2_groupBox4.Controls.Add(this.tab2_button7);
            this.tab2_groupBox4.Controls.Add(this.tab2_button6);
            this.tab2_groupBox4.Controls.Add(this.tab2_comboBox1);
            this.tab2_groupBox4.Location = new System.Drawing.Point(8, 122);
            this.tab2_groupBox4.Name = "tab2_groupBox4";
            this.tab2_groupBox4.Size = new System.Drawing.Size(157, 77);
            this.tab2_groupBox4.TabIndex = 4;
            this.tab2_groupBox4.TabStop = false;
            this.tab2_groupBox4.Text = "Zmien mapke";
            // 
            // tab2_comboBox1
            // 
            this.tab2_comboBox1.FormattingEnabled = true;
            this.tab2_comboBox1.Location = new System.Drawing.Point(6, 19);
            this.tab2_comboBox1.Name = "tab2_comboBox1";
            this.tab2_comboBox1.Size = new System.Drawing.Size(141, 21);
            this.tab2_comboBox1.TabIndex = 0;
            // 
            // tab2_button6
            // 
            this.tab2_button6.Location = new System.Drawing.Point(82, 46);
            this.tab2_button6.Name = "tab2_button6";
            this.tab2_button6.Size = new System.Drawing.Size(65, 21);
            this.tab2_button6.TabIndex = 1;
            this.tab2_button6.Text = "Wczytaj";
            this.tab2_button6.UseVisualStyleBackColor = true;
            this.tab2_button6.Click += new System.EventHandler(this.tab2_button6_Click);
            // 
            // tab2_button7
            // 
            this.tab2_button7.Location = new System.Drawing.Point(6, 46);
            this.tab2_button7.Name = "tab2_button7";
            this.tab2_button7.Size = new System.Drawing.Size(70, 21);
            this.tab2_button7.TabIndex = 2;
            this.tab2_button7.Text = "Ustaw";
            this.tab2_button7.UseVisualStyleBackColor = true;
            this.tab2_button7.Click += new System.EventHandler(this.tab2_button7_Click);
            // 
            // tab2_checkBox4
            // 
            this.tab2_checkBox4.AutoSize = true;
            this.tab2_checkBox4.Location = new System.Drawing.Point(6, 88);
            this.tab2_checkBox4.Name = "tab2_checkBox4";
            this.tab2_checkBox4.Size = new System.Drawing.Size(176, 17);
            this.tab2_checkBox4.TabIndex = 4;
            this.tab2_checkBox4.Text = "allow_spectators (obserwatorzy)";
            this.tab2_checkBox4.UseVisualStyleBackColor = true;
            this.tab2_checkBox4.CheckedChanged += new System.EventHandler(this.tab2_checkBox4_CheckedChanged);
            // 
            // tab3
            // 
            this.tab3.Controls.Add(this.logBox);
            this.tab3.Location = new System.Drawing.Point(4, 22);
            this.tab3.Name = "tab3";
            this.tab3.Padding = new System.Windows.Forms.Padding(3);
            this.tab3.Size = new System.Drawing.Size(379, 338);
            this.tab3.TabIndex = 3;
            this.tab3.Text = "Logi aplikacji";
            this.tab3.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logBox.Location = new System.Drawing.Point(3, 3);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(373, 332);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 364);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Half-Life RCON";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBoxRconConsole.ResumeLayout(false);
            this.groupBoxRconConsole.PerformLayout();
            this.groupBoxServer.ResumeLayout(false);
            this.groupBoxServer.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.mainTab.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tab1_groupBox3.ResumeLayout(false);
            this.tab1_groupBox3.PerformLayout();
            this.tab1_groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab1_numericUpDown2)).EndInit();
            this.tab1_groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab1_numericUpDown1)).EndInit();
            this.tab2.ResumeLayout(false);
            this.tab2_groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab2_numericUpDown1)).EndInit();
            this.tab2_groupBox2.ResumeLayout(false);
            this.tab2_groupBox2.PerformLayout();
            this.tab2_groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tab2_numericUpDown2)).EndInit();
            this.tab2_groupBox4.ResumeLayout(false);
            this.tab3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRconConsole;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.RichTextBox textBoxConsole;
        private System.Windows.Forms.GroupBox groupBoxServer;
        private System.Windows.Forms.MaskedTextBox textBoxPassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.CheckBox clearCommand;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage mainTab;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.GroupBox tab1_groupBox1;
        private System.Windows.Forms.Button tab1_button1;
        private System.Windows.Forms.NumericUpDown tab1_numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox textBoxAdress;
        private System.Windows.Forms.GroupBox tab1_groupBox2;
        private System.Windows.Forms.Button tab1_button2;
        private System.Windows.Forms.NumericUpDown tab1_numericUpDown2;
        private System.Windows.Forms.GroupBox tab1_groupBox3;
        private System.Windows.Forms.Button tab1_button3;
        private System.Windows.Forms.Label tab1_label2;
        private System.Windows.Forms.Button tab1_button4;
        private System.Windows.Forms.Button tab1_button5;
        private System.Windows.Forms.TabPage tab2;
        private System.Windows.Forms.GroupBox tab2_groupBox1;
        private System.Windows.Forms.Button tab2_button1;
        private System.Windows.Forms.NumericUpDown tab2_numericUpDown1;
        private System.Windows.Forms.Button tab2_button2;
        private System.Windows.Forms.GroupBox tab2_groupBox2;
        private System.Windows.Forms.CheckBox tab2_checkBox1;
        private System.Windows.Forms.CheckBox tab2_checkBox2;
        private System.Windows.Forms.CheckBox tab2_checkBox3;
        private System.Windows.Forms.Button tab2_button3;
        private System.Windows.Forms.GroupBox tab2_groupBox3;
        private System.Windows.Forms.Button tab2_button5;
        private System.Windows.Forms.Button tab2_button4;
        private System.Windows.Forms.NumericUpDown tab2_numericUpDown2;
        private System.Windows.Forms.GroupBox tab2_groupBox4;
        private System.Windows.Forms.Button tab2_button7;
        private System.Windows.Forms.Button tab2_button6;
        private System.Windows.Forms.ComboBox tab2_comboBox1;
        private System.Windows.Forms.CheckBox tab2_checkBox4;
        private System.Windows.Forms.TabPage tab3;
        private System.Windows.Forms.RichTextBox logBox;
    }
}

