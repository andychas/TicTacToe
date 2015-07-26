using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace TicTacToe.Client
{
    class GameButton : Button
    {
        const int MAXBOARDSIZE = 5;
        const int MINBOARDSIZE = 4;
        const int MAX_BOARD_BUTTON_SIZE = 100;
        const int MIN_BOARD_BUTTON_SIZE = 125;
        public int boardSize { get; set; }
        public int row { get; set; }
        public int col { get; set; }



        public GameButton(int boardSize, int row,int col)
        {
            this.boardSize = boardSize;
            this.row = row;
            this.col = col;

            this.Height = boardSize == MINBOARDSIZE ? MIN_BOARD_BUTTON_SIZE : MAX_BOARD_BUTTON_SIZE;
            this.Width = boardSize == MINBOARDSIZE ? MIN_BOARD_BUTTON_SIZE : MAX_BOARD_BUTTON_SIZE;
            this.SetValue(Grid.RowProperty, row);
            this.SetValue(Grid.ColumnProperty, col);          
            this.Content = "row " + row + " col " + col;
        }

    }
}
