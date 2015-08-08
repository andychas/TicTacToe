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


namespace TicTacToe.Client
{
    public partial class Form1 : Form,IServiceCallback
    {


        ServiceClient c;
        public Form1()
        {
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));

            this.StartPosition = FormStartPosition.CenterScreen;
            PlayBtn.Enabled = false;

            GetPlayers();
            
            
        }

        private void GetPlayers()
        {
            Player[] players = c.GetPlayers();
            foreach (Player player in players)
            {
                comboBox1.Items.Add(player.First_Name + " " + player.Last_Name);


            }
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            bool isRegistered;
            string[] playerInfo = comboBox1.Text.Split(' ');
            Player player = c.GetPlayer(playerInfo[0], playerInfo[1]);
            if (player != null)
            {
                isRegistered = c.RegisterClient(player);
                if (isRegistered)
                {
                  //  this.Visible = false;
                    PlayBtn.Enabled = false;
                    registerBtn.Enabled = false;
                    GameInfoForm gameInfo = new GameInfoForm(player);
                    gameInfo.Show();
                }
                else
                {
                    MessageBox.Show("Error registering player, This player might be already online");
                }
                
            }
            else
            {

            }
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

        private void registerBtn_Click(object sender, EventArgs e)
       { 
            RegisterForm f = new RegisterForm();
            f.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayBtn.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.removeClient();
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
