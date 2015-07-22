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


namespace TicTacToe.Client
{
    public partial class Form1 : Form
    {
        public static Form1 MainUI { get; set; }
        public Form1()
        {
            InitializeComponent();
            MainUI = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {         
   
        }

        /*private class MyCallBack : IServiceCallback
        {

        }*/

        private void NewPlayerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm f = new RegisterForm();
            f.Show();
        }

        private void ExistingPlayerBtn_Click(object sender, EventArgs e)
        {
            GameInfoForm gameInfo = new GameInfoForm();
            gameInfo.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void abuotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }
    }
}
