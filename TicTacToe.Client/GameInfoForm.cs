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
        private ServiceClient c = new ServiceClient();
        private string firstNamePlayer1;
        private string lastNamePlayer1;
        private string firstNamePlayer2;
        private string lastNamePlayer2;
        private int size = 4;
        private string gameOption = "computer";

        public GameInfoForm(string firstName, string lastName)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            this.firstNamePlayer1 = firstName;
            this.lastNamePlayer1 = lastName;
            playersComboBox.Enabled = false;
            Player[] players = c.GetPlayers();
            foreach (Player player in players)
            {
                if ((!player.First_Name.Equals(firstName)) || (!player.Last_Name.Equals(lastName)))
                {
                    playersComboBox.Items.Add(player.First_Name + " " + player.Last_Name);
                }    
            }
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            c.GameInfo(size, gameOption);

            GameBoard boardGame = new GameBoard(size, gameOption);
            boardGame.Show();
            boardGame.Text = firstNamePlayer1 + " " + lastNamePlayer1;

            if (gameOption.Equals("player"))
            {
                GameBoard boardGame2 = new GameBoard(size, gameOption);
                boardGame2.Text = firstNamePlayer2 + " " + lastNamePlayer2;
                boardGame2.Show();
            }

            this.Close();
        }

        private void GameInfoForm_Load(object sender, EventArgs e)
        {
            playerName.Text = "Hello " + firstNamePlayer1 + " " + lastNamePlayer1;
        }

        private void computerButton_CheckedChanged(object sender, EventArgs e)
        {
            gameOption = "computer";
            playersComboBox.Enabled = false;
        }

        private void playerButton_CheckedChanged(object sender, EventArgs e)
        {
            gameOption = "player";
            playersComboBox.Enabled = true;
        }

        private void playersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fullName = playersComboBox.Text;
            firstNamePlayer2 = fullName.Substring(0, fullName.IndexOf(' '));
            try
            {
                lastNamePlayer2 = fullName.Substring(fullName.IndexOf(' '), fullName.Length);
            }
            catch
            {
                lastNamePlayer2 = "";
            }
            
        }

        private void smallBoardButton_CheckedChanged(object sender, EventArgs e)
        {
            size = 4;
        }

        private void bigBoardButton_CheckedChanged(object sender, EventArgs e)
        {
            size = 5;
        }

    }
}
