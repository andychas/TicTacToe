namespace TicTacToe.Client
{
    partial class TicTacToeForm
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
            this.components = new System.ComponentModel.Container();
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.GameBoardPanel = new System.Windows.Forms.Panel();
            this.newGameBtn = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.GameInfoPanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.playersComboBox = new System.Windows.Forms.ComboBox();
            this.computerButton = new System.Windows.Forms.RadioButton();
            this.playerButton = new System.Windows.Forms.RadioButton();
            this.lvlGroupBox = new System.Windows.Forms.GroupBox();
            this.smallBoardButton = new System.Windows.Forms.RadioButton();
            this.bigBoardButton = new System.Windows.Forms.RadioButton();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChampComboBox = new System.Windows.Forms.ComboBox();
            this.playerName = new System.Windows.Forms.Label();
            this.AdvisorGroup3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.advisor3FirstName = new System.Windows.Forms.TextBox();
            this.advisor3LastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AdvisorGroup2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.advisor2FirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.advisor2LastName = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.playerFirstName = new System.Windows.Forms.TextBox();
            this.playerLastName = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.AdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdvisorGroup1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.advisor1LastName = new System.Windows.Forms.TextBox();
            this.advisor1FirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abuotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerBtn = new System.Windows.Forms.Button();
            this.PlayBtn = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.RegisterPanel.SuspendLayout();
            this.GameBoardPanel.SuspendLayout();
            this.GameInfoPanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lvlGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.AdvisorGroup3.SuspendLayout();
            this.AdvisorGroup2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.AdvisorGroup1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.Controls.Add(this.GameBoardPanel);
            this.RegisterPanel.Controls.Add(this.GameInfoPanel);
            this.RegisterPanel.Controls.Add(this.AdvisorGroup3);
            this.RegisterPanel.Controls.Add(this.AdvisorGroup2);
            this.RegisterPanel.Controls.Add(this.groupBox4);
            this.RegisterPanel.Controls.Add(this.SubmitBtn);
            this.RegisterPanel.Controls.Add(this.AdvisorComboBox);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.AdvisorGroup1);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Location = new System.Drawing.Point(0, 27);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(677, 496);
            this.RegisterPanel.TabIndex = 18;
            // 
            // GameBoardPanel
            // 
            this.GameBoardPanel.Controls.Add(this.newGameBtn);
            this.GameBoardPanel.Controls.Add(this.elementHost1);
            this.GameBoardPanel.Location = new System.Drawing.Point(3, 3);
            this.GameBoardPanel.Name = "GameBoardPanel";
            this.GameBoardPanel.Size = new System.Drawing.Size(677, 496);
            this.GameBoardPanel.TabIndex = 37;
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(518, 0);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(154, 87);
            this.newGameBtn.TabIndex = 3;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(0, 6);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(500, 478);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // GameInfoPanel
            // 
            this.GameInfoPanel.Controls.Add(this.groupBox2);
            this.GameInfoPanel.Controls.Add(this.lvlGroupBox);
            this.GameInfoPanel.Controls.Add(this.StartGameBtn);
            this.GameInfoPanel.Controls.Add(this.dataGridView1);
            this.GameInfoPanel.Controls.Add(this.groupBox3);
            this.GameInfoPanel.Controls.Add(this.playerName);
            this.GameInfoPanel.Location = new System.Drawing.Point(0, 3);
            this.GameInfoPanel.Name = "GameInfoPanel";
            this.GameInfoPanel.Size = new System.Drawing.Size(677, 496);
            this.GameInfoPanel.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.playersComboBox);
            this.groupBox2.Controls.Add(this.computerButton);
            this.groupBox2.Controls.Add(this.playerButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 73);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game Type";
            // 
            // playersComboBox
            // 
            this.playersComboBox.FormattingEnabled = true;
            this.playersComboBox.Location = new System.Drawing.Point(7, 66);
            this.playersComboBox.Name = "playersComboBox";
            this.playersComboBox.Size = new System.Drawing.Size(121, 21);
            this.playersComboBox.TabIndex = 6;
            this.playersComboBox.SelectedIndexChanged += new System.EventHandler(this.playersComboBox_SelectedIndexChanged);
            // 
            // computerButton
            // 
            this.computerButton.AutoSize = true;
            this.computerButton.Checked = true;
            this.computerButton.Location = new System.Drawing.Point(6, 19);
            this.computerButton.Name = "computerButton";
            this.computerButton.Size = new System.Drawing.Size(103, 17);
            this.computerButton.TabIndex = 5;
            this.computerButton.TabStop = true;
            this.computerButton.Text = "versus computer";
            this.computerButton.UseVisualStyleBackColor = true;
            this.computerButton.CheckedChanged += new System.EventHandler(this.computerButton_CheckedChanged);
            // 
            // playerButton
            // 
            this.playerButton.AutoSize = true;
            this.playerButton.Location = new System.Drawing.Point(6, 42);
            this.playerButton.Name = "playerButton";
            this.playerButton.Size = new System.Drawing.Size(87, 17);
            this.playerButton.TabIndex = 4;
            this.playerButton.TabStop = true;
            this.playerButton.Text = "versus player";
            this.playerButton.UseVisualStyleBackColor = true;
            this.playerButton.CheckedChanged += new System.EventHandler(this.playerButton_CheckedChanged);
            // 
            // lvlGroupBox
            // 
            this.lvlGroupBox.Controls.Add(this.smallBoardButton);
            this.lvlGroupBox.Controls.Add(this.bigBoardButton);
            this.lvlGroupBox.Location = new System.Drawing.Point(12, 19);
            this.lvlGroupBox.Name = "lvlGroupBox";
            this.lvlGroupBox.Size = new System.Drawing.Size(200, 48);
            this.lvlGroupBox.TabIndex = 14;
            this.lvlGroupBox.TabStop = false;
            this.lvlGroupBox.Text = "Game level";
            // 
            // smallBoardButton
            // 
            this.smallBoardButton.AutoSize = true;
            this.smallBoardButton.Checked = true;
            this.smallBoardButton.Location = new System.Drawing.Point(9, 19);
            this.smallBoardButton.Name = "smallBoardButton";
            this.smallBoardButton.Size = new System.Drawing.Size(48, 17);
            this.smallBoardButton.TabIndex = 1;
            this.smallBoardButton.TabStop = true;
            this.smallBoardButton.Text = "4 x 4";
            this.smallBoardButton.UseVisualStyleBackColor = true;
            // 
            // bigBoardButton
            // 
            this.bigBoardButton.AutoSize = true;
            this.bigBoardButton.Location = new System.Drawing.Point(80, 19);
            this.bigBoardButton.Name = "bigBoardButton";
            this.bigBoardButton.Size = new System.Drawing.Size(48, 17);
            this.bigBoardButton.TabIndex = 2;
            this.bigBoardButton.TabStop = true;
            this.bigBoardButton.Text = "5 x 5";
            this.bigBoardButton.UseVisualStyleBackColor = true;
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Location = new System.Drawing.Point(252, 278);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(124, 40);
            this.StartGameBtn.TabIndex = 13;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChampComboBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 179);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 49);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Championships";
            // 
            // ChampComboBox
            // 
            this.ChampComboBox.FormattingEnabled = true;
            this.ChampComboBox.Location = new System.Drawing.Point(9, 19);
            this.ChampComboBox.Name = "ChampComboBox";
            this.ChampComboBox.Size = new System.Drawing.Size(121, 21);
            this.ChampComboBox.TabIndex = 0;
            this.ChampComboBox.SelectedIndexChanged += new System.EventHandler(this.ChampComboBox_SelectedIndexChanged);
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(33, 3);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(0, 13);
            this.playerName.TabIndex = 16;
            // 
            // AdvisorGroup3
            // 
            this.AdvisorGroup3.Controls.Add(this.label8);
            this.AdvisorGroup3.Controls.Add(this.advisor3FirstName);
            this.AdvisorGroup3.Controls.Add(this.advisor3LastName);
            this.AdvisorGroup3.Controls.Add(this.label9);
            this.AdvisorGroup3.Location = new System.Drawing.Point(373, 227);
            this.AdvisorGroup3.Name = "AdvisorGroup3";
            this.AdvisorGroup3.Size = new System.Drawing.Size(226, 68);
            this.AdvisorGroup3.TabIndex = 35;
            this.AdvisorGroup3.TabStop = false;
            this.AdvisorGroup3.Text = "Advisor 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "First Name";
            // 
            // advisor3FirstName
            // 
            this.advisor3FirstName.Location = new System.Drawing.Point(94, 13);
            this.advisor3FirstName.Name = "advisor3FirstName";
            this.advisor3FirstName.Size = new System.Drawing.Size(100, 20);
            this.advisor3FirstName.TabIndex = 23;
            this.advisor3FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Advisor_Validating);
            // 
            // advisor3LastName
            // 
            this.advisor3LastName.Location = new System.Drawing.Point(94, 39);
            this.advisor3LastName.Name = "advisor3LastName";
            this.advisor3LastName.Size = new System.Drawing.Size(100, 20);
            this.advisor3LastName.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Last Name";
            // 
            // AdvisorGroup2
            // 
            this.AdvisorGroup2.Controls.Add(this.label6);
            this.AdvisorGroup2.Controls.Add(this.advisor2FirstName);
            this.AdvisorGroup2.Controls.Add(this.label7);
            this.AdvisorGroup2.Controls.Add(this.advisor2LastName);
            this.AdvisorGroup2.Location = new System.Drawing.Point(373, 153);
            this.AdvisorGroup2.Name = "AdvisorGroup2";
            this.AdvisorGroup2.Size = new System.Drawing.Size(226, 68);
            this.AdvisorGroup2.TabIndex = 34;
            this.AdvisorGroup2.TabStop = false;
            this.AdvisorGroup2.Text = "Advisor 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "First Name";
            // 
            // advisor2FirstName
            // 
            this.advisor2FirstName.Location = new System.Drawing.Point(97, 16);
            this.advisor2FirstName.Name = "advisor2FirstName";
            this.advisor2FirstName.Size = new System.Drawing.Size(100, 20);
            this.advisor2FirstName.TabIndex = 21;
            this.advisor2FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Advisor_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Last Name";
            // 
            // advisor2LastName
            // 
            this.advisor2LastName.Location = new System.Drawing.Point(97, 42);
            this.advisor2LastName.Name = "advisor2LastName";
            this.advisor2LastName.Size = new System.Drawing.Size(100, 20);
            this.advisor2LastName.TabIndex = 22;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.playerFirstName);
            this.groupBox4.Controls.Add(this.playerLastName);
            this.groupBox4.Location = new System.Drawing.Point(67, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(224, 100);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Player Info";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // playerFirstName
            // 
            this.playerFirstName.Location = new System.Drawing.Point(99, 29);
            this.playerFirstName.Name = "playerFirstName";
            this.playerFirstName.Size = new System.Drawing.Size(100, 20);
            this.playerFirstName.TabIndex = 6;
            this.playerFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.playerFirstName_Validating);
            // 
            // playerLastName
            // 
            this.playerLastName.Location = new System.Drawing.Point(99, 60);
            this.playerLastName.Name = "playerLastName";
            this.playerLastName.Size = new System.Drawing.Size(100, 20);
            this.playerLastName.TabIndex = 7;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(292, 299);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 31;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // AdvisorComboBox
            // 
            this.AdvisorComboBox.FormattingEnabled = true;
            this.AdvisorComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.AdvisorComboBox.Location = new System.Drawing.Point(462, 59);
            this.AdvisorComboBox.Name = "AdvisorComboBox";
            this.AdvisorComboBox.Size = new System.Drawing.Size(39, 21);
            this.AdvisorComboBox.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(376, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Advisors";
            // 
            // AdvisorGroup1
            // 
            this.AdvisorGroup1.Controls.Add(this.label3);
            this.AdvisorGroup1.Controls.Add(this.label15);
            this.AdvisorGroup1.Controls.Add(this.advisor1LastName);
            this.AdvisorGroup1.Controls.Add(this.advisor1FirstName);
            this.AdvisorGroup1.Location = new System.Drawing.Point(373, 86);
            this.AdvisorGroup1.Name = "AdvisorGroup1";
            this.AdvisorGroup1.Size = new System.Drawing.Size(226, 68);
            this.AdvisorGroup1.TabIndex = 33;
            this.AdvisorGroup1.TabStop = false;
            this.AdvisorGroup1.Text = "Advisor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "First Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Last Name";
            // 
            // advisor1LastName
            // 
            this.advisor1LastName.Location = new System.Drawing.Point(97, 39);
            this.advisor1LastName.Name = "advisor1LastName";
            this.advisor1LastName.Size = new System.Drawing.Size(100, 20);
            this.advisor1LastName.TabIndex = 20;
            // 
            // advisor1FirstName
            // 
            this.advisor1FirstName.Location = new System.Drawing.Point(97, 13);
            this.advisor1FirstName.Name = "advisor1FirstName";
            this.advisor1FirstName.Size = new System.Drawing.Size(100, 20);
            this.advisor1FirstName.TabIndex = 19;
            this.advisor1FirstName.Validating += new System.ComponentModel.CancelEventHandler(this.Advisor_Validating);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(63, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(213, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 78);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Exisiting Player";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abuotToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // abuotToolStripMenuItem
            // 
            this.abuotToolStripMenuItem.Name = "abuotToolStripMenuItem";
            this.abuotToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.abuotToolStripMenuItem.Text = "Abuot Box";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(126, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(213, 182);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(110, 52);
            this.registerBtn.TabIndex = 4;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // PlayBtn
            // 
            this.PlayBtn.Location = new System.Drawing.Point(364, 182);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(109, 52);
            this.PlayBtn.TabIndex = 5;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TicTacToeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 523);
            this.Controls.Add(this.RegisterPanel);
            this.Controls.Add(this.PlayBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "TicTacToeForm";
            this.Text = "TicTacToeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TicTacToeForm_FormClosing);
            this.Load += new System.EventHandler(this.TicTacToeForm_Load);
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.GameBoardPanel.ResumeLayout(false);
            this.GameInfoPanel.ResumeLayout(false);
            this.GameInfoPanel.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lvlGroupBox.ResumeLayout(false);
            this.lvlGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.AdvisorGroup3.ResumeLayout(false);
            this.AdvisorGroup3.PerformLayout();
            this.AdvisorGroup2.ResumeLayout(false);
            this.AdvisorGroup2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.AdvisorGroup1.ResumeLayout(false);
            this.AdvisorGroup1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abuotToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.GroupBox AdvisorGroup3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox advisor3FirstName;
        private System.Windows.Forms.TextBox advisor3LastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox AdvisorGroup2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox advisor2FirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox advisor2LastName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playerFirstName;
        private System.Windows.Forms.TextBox playerLastName;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ComboBox AdvisorComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox AdvisorGroup1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox advisor1LastName;
        private System.Windows.Forms.TextBox advisor1FirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Panel GameBoardPanel;
        private System.Windows.Forms.Button newGameBtn;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Panel GameInfoPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox playersComboBox;
        private System.Windows.Forms.RadioButton computerButton;
        private System.Windows.Forms.RadioButton playerButton;
        private System.Windows.Forms.GroupBox lvlGroupBox;
        private System.Windows.Forms.RadioButton smallBoardButton;
        private System.Windows.Forms.RadioButton bigBoardButton;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ChampComboBox;
        private System.Windows.Forms.Label playerName;



    }
}