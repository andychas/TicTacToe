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
            this.label4 = new System.Windows.Forms.Label();
            this.AdvisorComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.playerFirstName = new System.Windows.Forms.TextBox();
            this.playerLastName = new System.Windows.Forms.TextBox();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AdvisorGroup1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.advisor1LastName = new System.Windows.Forms.TextBox();
            this.advisor1FirstName = new System.Windows.Forms.TextBox();
            this.AdvisorGroup2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.advisor2FirstName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.advisor2LastName = new System.Windows.Forms.TextBox();
            this.AdvisorGroup3 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.advisor3FirstName = new System.Windows.Forms.TextBox();
            this.advisor3LastName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.AdvisorGroup1.SuspendLayout();
            this.AdvisorGroup2.SuspendLayout();
            this.AdvisorGroup3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.playerFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
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
            this.SubmitBtn.Location = new System.Drawing.Point(241, 277);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.SubmitBtn.TabIndex = 8;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.SubmitBtn_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.playerFirstName);
            this.groupBox1.Controls.Add(this.playerLastName);
            this.groupBox1.Location = new System.Drawing.Point(16, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Player Info";
            // 
            // AdvisorGroup1
            // 
            this.AdvisorGroup1.Controls.Add(this.label3);
            this.AdvisorGroup1.Controls.Add(this.label15);
            this.AdvisorGroup1.Controls.Add(this.advisor1LastName);
            this.AdvisorGroup1.Controls.Add(this.advisor1FirstName);
            this.AdvisorGroup1.Location = new System.Drawing.Point(322, 64);
            this.AdvisorGroup1.Name = "AdvisorGroup1";
            this.AdvisorGroup1.Size = new System.Drawing.Size(226, 68);
            this.AdvisorGroup1.TabIndex = 25;
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
            // AdvisorGroup2
            // 
            this.AdvisorGroup2.Controls.Add(this.label6);
            this.AdvisorGroup2.Controls.Add(this.advisor2FirstName);
            this.AdvisorGroup2.Controls.Add(this.label7);
            this.AdvisorGroup2.Controls.Add(this.advisor2LastName);
            this.AdvisorGroup2.Location = new System.Drawing.Point(322, 131);
            this.AdvisorGroup2.Name = "AdvisorGroup2";
            this.AdvisorGroup2.Size = new System.Drawing.Size(226, 68);
            this.AdvisorGroup2.TabIndex = 26;
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
            // AdvisorGroup3
            // 
            this.AdvisorGroup3.Controls.Add(this.label8);
            this.AdvisorGroup3.Controls.Add(this.advisor3FirstName);
            this.AdvisorGroup3.Controls.Add(this.advisor3LastName);
            this.AdvisorGroup3.Controls.Add(this.label9);
            this.AdvisorGroup3.Location = new System.Drawing.Point(322, 205);
            this.AdvisorGroup3.Name = "AdvisorGroup3";
            this.AdvisorGroup3.Size = new System.Drawing.Size(226, 68);
            this.AdvisorGroup3.TabIndex = 27;
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
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 312);
            this.Controls.Add(this.AdvisorGroup3);
            this.Controls.Add(this.AdvisorGroup2);
            this.Controls.Add(this.AdvisorGroup1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SubmitBtn);
            this.Controls.Add(this.AdvisorComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.AdvisorGroup1.ResumeLayout(false);
            this.AdvisorGroup1.PerformLayout();
            this.AdvisorGroup2.ResumeLayout(false);
            this.AdvisorGroup2.PerformLayout();
            this.AdvisorGroup3.ResumeLayout(false);
            this.AdvisorGroup3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox AdvisorComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox playerFirstName;
        private System.Windows.Forms.TextBox playerLastName;
        private System.Windows.Forms.Button SubmitBtn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox AdvisorGroup2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox advisor2FirstName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox advisor2LastName;
        private System.Windows.Forms.GroupBox AdvisorGroup1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox advisor1LastName;
        private System.Windows.Forms.TextBox advisor1FirstName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox AdvisorGroup3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox advisor3FirstName;
        private System.Windows.Forms.TextBox advisor3LastName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}