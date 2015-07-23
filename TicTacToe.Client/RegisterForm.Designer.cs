namespace TicTacToe.Client
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.AdvisorPanel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.AdvisorPanel2 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.AdvisorPanel3 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.msgLabel = new System.Windows.Forms.Label();
            this.AdvisorPanel1.SuspendLayout();
            this.AdvisorPanel2.SuspendLayout();
            this.AdvisorPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rgister";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Player";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Advisors";
            // 
            // AdvisorComboBox
            // 
            this.AdvisorComboBox.FormattingEnabled = true;
            this.AdvisorComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.AdvisorComboBox.Location = new System.Drawing.Point(411, 37);
            this.AdvisorComboBox.Name = "AdvisorComboBox";
            this.AdvisorComboBox.Size = new System.Drawing.Size(39, 21);
            this.AdvisorComboBox.TabIndex = 4;
            this.AdvisorComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Last Name";
            // 
            // firstNameText
            // 
            this.firstNameText.Location = new System.Drawing.Point(118, 64);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(100, 20);
            this.firstNameText.TabIndex = 6;
            this.firstNameText.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(118, 95);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(100, 20);
            this.lastNameText.TabIndex = 7;
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Location = new System.Drawing.Point(241, 277);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 8;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "First Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "First Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "First Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Last Name";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(97, 11);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(97, 37);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(97, 17);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(97, 43);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(97, 14);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(97, 40);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 20;
            // 
            // AdvisorPanel1
            // 
            this.AdvisorPanel1.Controls.Add(this.label12);
            this.AdvisorPanel1.Controls.Add(this.label6);
            this.AdvisorPanel1.Controls.Add(this.label7);
            this.AdvisorPanel1.Controls.Add(this.textBox4);
            this.AdvisorPanel1.Controls.Add(this.textBox3);
            this.AdvisorPanel1.Location = new System.Drawing.Point(325, 67);
            this.AdvisorPanel1.Name = "AdvisorPanel1";
            this.AdvisorPanel1.Size = new System.Drawing.Size(200, 63);
            this.AdvisorPanel1.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 1);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Advisor 1";
            // 
            // AdvisorPanel2
            // 
            this.AdvisorPanel2.Controls.Add(this.label13);
            this.AdvisorPanel2.Controls.Add(this.label8);
            this.AdvisorPanel2.Controls.Add(this.textBox5);
            this.AdvisorPanel2.Controls.Add(this.label9);
            this.AdvisorPanel2.Controls.Add(this.textBox6);
            this.AdvisorPanel2.Location = new System.Drawing.Point(325, 136);
            this.AdvisorPanel2.Name = "AdvisorPanel2";
            this.AdvisorPanel2.Size = new System.Drawing.Size(200, 63);
            this.AdvisorPanel2.TabIndex = 22;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Advisor 2";
            // 
            // AdvisorPanel3
            // 
            this.AdvisorPanel3.Controls.Add(this.label14);
            this.AdvisorPanel3.Controls.Add(this.label10);
            this.AdvisorPanel3.Controls.Add(this.textBox7);
            this.AdvisorPanel3.Controls.Add(this.textBox8);
            this.AdvisorPanel3.Controls.Add(this.label11);
            this.AdvisorPanel3.Location = new System.Drawing.Point(325, 205);
            this.AdvisorPanel3.Name = "AdvisorPanel3";
            this.AdvisorPanel3.Size = new System.Drawing.Size(200, 63);
            this.AdvisorPanel3.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 1);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Advisor 3";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // msgLabel
            // 
            this.msgLabel.Location = new System.Drawing.Point(13, 179);
            this.msgLabel.Name = "msgLabel";
            this.msgLabel.Size = new System.Drawing.Size(205, 23);
            this.msgLabel.TabIndex = 24;
            this.msgLabel.Text = "msgLabel";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 312);
            this.Controls.Add(this.msgLabel);
            this.Controls.Add(this.AdvisorPanel3);
            this.Controls.Add(this.AdvisorPanel2);
            this.Controls.Add(this.AdvisorPanel1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.lastNameText);
            this.Controls.Add(this.firstNameText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AdvisorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.AdvisorPanel1.ResumeLayout(false);
            this.AdvisorPanel1.PerformLayout();
            this.AdvisorPanel2.ResumeLayout(false);
            this.AdvisorPanel2.PerformLayout();
            this.AdvisorPanel3.ResumeLayout(false);
            this.AdvisorPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AdvisorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Panel AdvisorPanel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel AdvisorPanel2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel AdvisorPanel3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label msgLabel;
    }
}