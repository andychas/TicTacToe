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
    public partial class PlayersForChampForm : Form, IServiceCallback
    {

        private ServiceClient c;

        public PlayersForChampForm()
        {
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            Championship[] champiomships = c.GetAllChampionships();
            foreach (Championship champ in champiomships)
            {
                comboBox1.Items.Add(champ.Id);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int champId = Convert.ToInt32(comboBox1.Text);
            Player[] players = c.GetPlayersByChampionshipId(champId);
            label1.Text = "All players played in the championship  " + champId;
            bindingSource1.DataSource = players;
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
