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

namespace TicTacToe.Client
{

    public partial class GameBoard : Form,IServiceCallback
    {

        private int size;
        private string gameOption;
        private Player player1;
        private Player player2;
/*
        public GameBoard(int size, string gameOption)
        {
            InitializeComponent();
            this.size = size;
            this.gameOption = gameOption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            elementHost1.Child = new GameBoardWPF(size, gameOption);
        }
*/
        public GameBoard(int size, string gameOption, Player player1, Player player2)
        {
            InitializeComponent();
            this.size = size;
            this.gameOption = gameOption;
            this.player1 = player1;
            this.player2 = player2;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            elementHost1.Child = new GameBoardWPF(size, gameOption,player1,player2);


        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            elementHost1.Child = new GameBoardWPF(size, gameOption,player1,player2);
        }

        private void elementHost1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }


        public void UpdateClientBoard(int col, int row)
        {
            throw new NotImplementedException();
        }

        public void ConfirmPlayer(int gameSize, Player player1, Player player2)
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }
    }
}
