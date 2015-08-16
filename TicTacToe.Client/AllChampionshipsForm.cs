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
    public partial class AllChampionshipsForm : Form, IServiceCallback
    {

        private ServiceClient c;

        public AllChampionshipsForm()
        {
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            Championship[] championships = c.GetAllChampionships();
            bindingSource1.DataSource = championships;
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
