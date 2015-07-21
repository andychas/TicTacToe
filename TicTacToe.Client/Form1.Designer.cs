namespace TicTacToe.Client
{
    partial class Form1
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
            this.NewPlayerBtn = new System.Windows.Forms.Button();
            this.ExistingPlayerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewPlayerBtn
            // 
            this.NewPlayerBtn.Location = new System.Drawing.Point(12, 96);
            this.NewPlayerBtn.Name = "NewPlayerBtn";
            this.NewPlayerBtn.Size = new System.Drawing.Size(110, 52);
            this.NewPlayerBtn.TabIndex = 0;
            this.NewPlayerBtn.Text = "New Player";
            this.NewPlayerBtn.UseVisualStyleBackColor = true;
            this.NewPlayerBtn.Click += new System.EventHandler(this.NewPlayerBtn_Click);
            // 
            // ExistingPlayerBtn
            // 
            this.ExistingPlayerBtn.Location = new System.Drawing.Point(163, 96);
            this.ExistingPlayerBtn.Name = "ExistingPlayerBtn";
            this.ExistingPlayerBtn.Size = new System.Drawing.Size(109, 52);
            this.ExistingPlayerBtn.TabIndex = 1;
            this.ExistingPlayerBtn.Text = "Existing Player";
            this.ExistingPlayerBtn.UseVisualStyleBackColor = true;
            this.ExistingPlayerBtn.Click += new System.EventHandler(this.ExistingPlayerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExistingPlayerBtn);
            this.Controls.Add(this.NewPlayerBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewPlayerBtn;
        private System.Windows.Forms.Button ExistingPlayerBtn;

    }
}

