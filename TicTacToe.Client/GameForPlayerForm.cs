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

        public GameForPlayerForm()
        {
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            Player[] players = c.GetPlayers();
            foreach (Player p in players)
            {
                comboBox1.Items.Add(p.Id + " " + p.First_Name + " " + p.Last_Name);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] playerInfo = comboBox1.Text.Split(' ');

            player = c.GetPlayer(playerInfo[1], playerInfo[2]);
            label1.Text = "All games for " + player.First_Name + " " + player.Last_Name;
            Game[] games = c.GetPlayerGames(player);
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

        
    }
}
