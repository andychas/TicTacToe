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
            ServiceClient c = new ServiceClient();
            if (radioButton1.Checked)
            {
                size = 4;
                c.SizeGame(size);
            }
            else if (radioButton2.Checked) 
            {
                size = 5;
                c.SizeGame(size);
            }
               
            else { }
                // SELECT RADIO BUTTON MSG !
                // SEND TO SERVVER WICH GAME BOARD + AGAINST PC/ AGAINST PLAYER
            
            GameBoard b = new GameBoard(size);
            b.Show();
        }

    }
}
