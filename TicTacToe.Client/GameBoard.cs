using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Client
{
    public partial class GameBoard : Form
    {
        private int size;
        private string gameOption;

        public GameBoard(int size, string gameOption)
        {
            InitializeComponent();
            this.size = size;
            this.gameOption = gameOption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            elementHost1.Child = new GameBoardWPF(size, gameOption);
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            elementHost1.Child = new GameBoardWPF(size, gameOption);
        }
    }
}
