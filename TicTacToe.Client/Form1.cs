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
    public partial class Form1 : Form
    {
        private ServiceClient c = new ServiceClient();
        public static Form1 MainUI { get; set; }

        public Form1()
        {
            InitializeComponent();
            MainUI = this;
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            if (!firstNameText.Equals(""))
            {
                IEnumerable<Tuple<int, string, string>> player = c.GetPlayer(firstNameText.Text, lastNameText.Text);
                if (player.Count() > 0)
                {
                    string PlayerFirstName = player.ElementAt(0).Item2;
                    string PlayerLastName = player.ElementAt(0).Item3;
                    GameInfoForm gameInfo = new GameInfoForm(PlayerFirstName, PlayerLastName);
                    gameInfo.Show();
                }
                else
                {
                    MessageBox.Show("Error with name");
                }
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

    }
}
