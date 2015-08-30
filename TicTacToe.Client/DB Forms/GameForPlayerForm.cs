using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Client.ServiceReference1;

namespace TicTacToe.Client
{
    public partial class GameForPlayerForm : Form, IServiceCallback
    {

        private ServiceClient c;
        private Player player;
        private int delay;

        public GameForPlayerForm(int delay)
        {
            // TODO: Complete member initialization
            this.delay = delay;
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            Player[] players = c.GetPlayers();
            foreach (Player p in players)
            {
                comboBox1.Items.Add(p.Id + " " + p.First_Name + " " + p.Last_Name);
            }
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] playerInfo = comboBox1.Text.Split(' ');

            player = c.GetPlayer(playerInfo[1], playerInfo[2]);
            label1.Text = "All games for " + player.First_Name + " " + player.Last_Name;
            
            Game[] games = await c.GetPlayerGamesQueryAsync(player,delay);
            bindingSource1.DataSource = games;
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        public void UpdateClientBoard(int col, int row)
        {
            throw new NotImplementedException();
        }

        public void ConfirmPlayer(int gameSize, Player player1, Player player2, bool confirmationRequired)
        {
            throw new NotImplementedException();
        }

        public void StartGame(bool isYourTurn, char sign)
        {
            throw new NotImplementedException();
        }




        public void MakeYourTurn(int row, int col)
        {
            throw new NotImplementedException();
        }


        public void ConfirmPlayer(int gameSize, Player player1, Player player2, bool confirmationRequired, int gameId)
        {
            throw new NotImplementedException();
        }


        public void GameWon(string sign)
        {
            throw new NotImplementedException();
        }

        public void GameTied()
        {
            throw new NotImplementedException();
        }


        public void GameCanceled()
        {
            throw new NotImplementedException();
        }
    }
}
