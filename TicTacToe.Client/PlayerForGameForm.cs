﻿using System;
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
    public partial class PlayerForGameForm : Form, IServiceCallback
    {

        private ServiceClient c;

        public PlayerForGameForm()
        {
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            Game[] games = c.GetGames();
            foreach (Game g in games)
            {
                comboBox1.Items.Add(g.Id);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gameId = comboBox1.Text;
            Player[] players = c.GetAllGamePlayer(gameId);
            label1.Text = "All players played in the game  " + gameId;
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
