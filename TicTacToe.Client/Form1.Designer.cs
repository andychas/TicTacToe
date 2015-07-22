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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abuotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
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
            this.abuotToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abuotToolStripMenuItem.Text = "Abuot Box";
            this.abuotToolStripMenuItem.Click += new System.EventHandler(this.abuotToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ExistingPlayerBtn);
            this.Controls.Add(this.NewPlayerBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewPlayerBtn;
        private System.Windows.Forms.Button ExistingPlayerBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abuotToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

    }
}

