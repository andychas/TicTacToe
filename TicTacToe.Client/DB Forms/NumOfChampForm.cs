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
    public partial class NumOfChampForm : Form, IServiceCallback
    {

        private ServiceClient c;
        private int delay;

        public NumOfChampForm(int delay)
        {
            this.delay = delay;
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            string[] cities = c.GetAllCities();
            List<CustomChampionship> l = new List<CustomChampionship>();

            for (int i = 0; i < cities.Length; i++)
            {
                CustomChampionship customChampionship = c.GetNumOfChampionships(cities[i]);
                l.Add(customChampionship);

            }
            bindingSource1.DataSource = l;
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
