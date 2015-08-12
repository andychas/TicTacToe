using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Client.ServiceReference1;
using System.ServiceModel;
using System.Windows.Forms.Integration;

namespace TicTacToe.Client.classes
{
    class Class1: UserControl
    {
        private Button newGameBtn;
        private ElementHost elementHost1;
    
        private void InitializeComponent()
        {
            this.newGameBtn = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // newGameBtn
            // 
            this.newGameBtn.Location = new System.Drawing.Point(509, 3);
            this.newGameBtn.Name = "newGameBtn";
            this.newGameBtn.Size = new System.Drawing.Size(154, 87);
            this.newGameBtn.TabIndex = 3;
            this.newGameBtn.Text = "New Game";
            this.newGameBtn.UseVisualStyleBackColor = true;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(3, 3);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(500, 500);
            this.elementHost1.TabIndex = 2;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // Class1
            // 
            this.Controls.Add(this.newGameBtn);
            this.Controls.Add(this.elementHost1);
            this.Name = "Class1";
            this.Size = new System.Drawing.Size(668, 511);
            this.ResumeLayout(false);

        }
    }
}
