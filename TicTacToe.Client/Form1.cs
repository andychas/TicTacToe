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
        #region "callback services"
        private class CallBack : IServiceCallback
        {

            public void UpdateClientBoard(int col, int row)
            {

            }


            public void ConfirmPlayer(Player player)
            {
                throw new NotImplementedException();
            }
        }
        #endregion

        ServiceClient c = new ServiceClient(new InstanceContext(new CallBack()));
        public static Form1 MainUI { get; set; }

        public Form1()
        {
            InitializeComponent();
            MainUI = this;
            this.StartPosition = FormStartPosition.CenterScreen;
            PlayBtn.Enabled = false;
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

    }
}
