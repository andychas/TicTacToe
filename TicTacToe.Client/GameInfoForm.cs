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
    public partial class GameInfoForm : Form
    {
        public GameInfoForm()
        {
            InitializeComponent();
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            int size = 0;
            if(radioButton1.Checked)
                size = 4;
            else if (radioButton2.Checked)
                size = 5;
            else{}
                // SELECT RADIO BUTTON MSG !
                // SEND TO SERVVER WICH GAME BOARD + AGAINST PC/ AGAINST PLAYER
            
            GameBoard b = new GameBoard(size);
            b.Show();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServiceClient c = new ServiceClient();
            
        }

    }
}
