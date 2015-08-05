namespace TicTacToe.Client
{
    partial class GameInfoForm
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
            this.smallBoardButton = new System.Windows.Forms.RadioButton();
            this.bigBoardButton = new System.Windows.Forms.RadioButton();
            this.playerButton = new System.Windows.Forms.RadioButton();
            this.computerButton = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.StartGameBtn = new System.Windows.Forms.Button();
            this.lvlGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.playersComboBox = new System.Windows.Forms.ComboBox();
            this.playerName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ChampComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.lvlGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
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
            this.smallBoardButton.CheckedChanged += new System.EventHandler(this.smallBoardButton_CheckedChanged);
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
            this.bigBoardButton.CheckedChanged += new System.EventHandler(this.bigBoardButton_CheckedChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(323, 60);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // StartGameBtn
            // 
            this.StartGameBtn.Location = new System.Drawing.Point(240, 287);
            this.StartGameBtn.Name = "StartGameBtn";
            this.StartGameBtn.Size = new System.Drawing.Size(75, 23);
            this.StartGameBtn.TabIndex = 7;
            this.StartGameBtn.Text = "Start Game";
            this.StartGameBtn.UseVisualStyleBackColor = true;
            this.StartGameBtn.Click += new System.EventHandler(this.StartGameBtn_Click);
            // 
            // lvlGroupBox
            // 
            this.lvlGroupBox.Controls.Add(this.smallBoardButton);
            this.lvlGroupBox.Controls.Add(this.bigBoardButton);
            this.lvlGroupBox.Location = new System.Drawing.Point(12, 29);
            this.lvlGroupBox.Name = "lvlGroupBox";
            this.lvlGroupBox.Size = new System.Drawing.Size(200, 48);
            this.lvlGroupBox.TabIndex = 8;
            this.lvlGroupBox.TabStop = false;
            this.lvlGroupBox.Text = "Game level";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.playersComboBox);
            this.groupBox1.Controls.Add(this.computerButton);
            this.groupBox1.Controls.Add(this.playerButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Type";
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
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(33, 13);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(0, 13);
            this.playerName.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ChampComboBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 189);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 49);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Championships";
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
            // GameInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 322);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvlGroupBox);
            this.Controls.Add(this.StartGameBtn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "GameInfoForm";
            this.Text = "GameInfoForm";
            this.Load += new System.EventHandler(this.GameInfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.lvlGroupBox.ResumeLayout(false);
            this.lvlGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton smallBoardButton;
        private System.Windows.Forms.RadioButton bigBoardButton;
        private System.Windows.Forms.RadioButton playerButton;
        private System.Windows.Forms.RadioButton computerButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button StartGameBtn;
        private System.Windows.Forms.GroupBox lvlGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.ComboBox playersComboBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox ChampComboBox;
    }
}