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
using System.Threading;

namespace TicTacToe.Client
{
    
    public partial class GameInfoForm : Form
    {
        #region "callback services"
         private class CallBack : IServiceCallback
        {

            public void UpdateClientBoard(int col, int row)
            {

            }


            public void ConfirmPlayer(Player player)
            {
                
            }
        }
        #endregion

        ServiceClient c = new ServiceClient(new InstanceContext(new CallBack()));
        
        private string firstNamePlayer1;
        private string lastNamePlayer1;
        private string firstNamePlayer2;
        private string lastNamePlayer2;
        private string championship = "";
        private int champId;  
        private string gameOption = "computer";
        private int size = 4;
        private Player player1;
        private Player player2;

        public GameInfoForm(Player player)
        {
            // TODO: Complete member initialization
            this.player1 = player;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            playersComboBox.Enabled = false;
            initAllData();

        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {


            c.GameInfo(size, gameOption);
            if (!championship.Equals("")) // if selected championship
            {
                champId = Int32.Parse(championship.Substring(0, championship.IndexOf(' ')));
                c.AddPlayerToChamp(player1, champId);
                if (firstNamePlayer2 != null) // if selected player2
                {
                    player2.First_Name = firstNamePlayer2;
                    player2.Last_Name = lastNamePlayer2;
                    c.AddPlayerToChamp(player2, champId);
                }
            }
            
            
            GameBoard boardGame = new GameBoard(size, gameOption,player1,player2);
            boardGame.Show();
            boardGame.Text = firstNamePlayer1 + " " + lastNamePlayer1;


            if (gameOption.Equals("player"))
            {
                GameBoard boardGame2 = new GameBoard(size, gameOption,player1,player2);
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
            StartGameBtn.Text = "Start Game";
        }

        private void playerButton_CheckedChanged(object sender, EventArgs e)
        {
            gameOption = "player";
            playersComboBox.Enabled = true;
            StartGameBtn.Text = "Duel Player";
                 
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

        private void ChampComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            championship = ChampComboBox.Text;
        }

        private void initAllData()
        {
            Player[] players = c.GetPlayers();
            foreach (Player player in players)
            {
                if ((!player.First_Name.Equals(player1.First_Name)) || (!player.Last_Name.Equals(player1.Last_Name)))
                {
                    playersComboBox.Items.Add(player.First_Name + " " + player.Last_Name);
                }
            }

            Championship[] championships = c.GetChampionships();
            foreach (Championship champ in championships)
            {
                ChampComboBox.Items.Add(champ.Id + " " + champ.City);
            }
        }

    }
}
