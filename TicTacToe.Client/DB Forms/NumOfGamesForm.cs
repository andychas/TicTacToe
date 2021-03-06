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
    public partial class NumOfGamesForm : Form, IServiceCallback
    {

        private ServiceClient c;
        private int delay;

        public NumOfGamesForm(int delay)
        {
            this.delay = delay;
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));

            
            Player[] players = c.GetPlayers();
            List<CustomPlayer> p = new List<CustomPlayer>();

            for (int i = 0; i < players.Count(); i++)
            {
                string name = players[i].First_Name + " " + players[i].Last_Name;
                CustomPlayer customPlayer = c.GetNumOfGames(name);
                p.Add(customPlayer);
            }

            bindingSource1.DataSource = p;
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
