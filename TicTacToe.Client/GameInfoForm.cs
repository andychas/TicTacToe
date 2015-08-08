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
    
    public partial class GameInfoForm : Form,IServiceCallback
    {
        ServiceClient c;
        private string championship = "";
        private int champId;
        private string gameOption = "computer";
        private int size = 4;
        private Player player1;
        private Player player2;          

        public GameInfoForm(Player player)
        {

            // TODO: Complete member initialization
            c =  new ServiceClient(new InstanceContext(this));
            InitializeComponent();
            player1 = new Player();
            this.player1 = player;
            this.StartPosition = FormStartPosition.CenterScreen;
            playersComboBox.Enabled = false;
            initAllData();


        }


        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            if (gameOption == "computer") // vs computer
            {

            }
            else                          // vs player
            {
                c.AskPlayerConfirmation(size,player1, player2);
                GameBoard boardGame = new GameBoard(size, gameOption, player1, player2);
                boardGame.Show();
                boardGame.Text = player1.First_Name + " " + player1.Last_Name;
                
            }






            c.GameInfo(size, gameOption);
            /*
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
 */           
            
            
            
           
            this.Close();
        }

        private void GameInfoForm_Load(object sender, EventArgs e)
        {
            playerName.Text = "Hello " + player1.First_Name + " " + player1.Last_Name;
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
            string[] playerInfo = playersComboBox.Text.Split(' ');
            player2 = c.GetPlayer(playerInfo[0], playerInfo[1]);
/*
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
  */          
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

        public void UpdateClientBoard(int col, int row)
        {
            throw new NotImplementedException();
        }

        public void ConfirmPlayer(int gameSize, Player player1, Player player2)
        {
            DialogResult dialogResult = MessageBox.Show(player2.First_Name + ": " + player1.First_Name + " wants to play against you ", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {

                // GameBoard boardGame = new GameBoard(size, gameOption, player1, player2);
                //  boardGame.Show();
                // boardGame.Text = player1.First_Name + " " + player1.Last_Name;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }

        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}

/*
public void ConfirmPlayer(Player player1, Player player2)
        {
            
        }
*/