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
            ServiceClient c = new ServiceClient();
            int size = 0;
            string gameOption = "";
            
            
            if (smallBoardButton.Checked)
                size = 4;
            else if (bigBoardButton.Checked) 
                size = 5;
            
            if (computerButton.Checked)
                gameOption = "computer";
            else if (playerButton.Checked)
                gameOption = "player";
           
            c.GameInfo(size, gameOption);

            GameBoard b = new GameBoard(size, gameOption);
            b.Show();
            this.Close();
        }
    }
}
