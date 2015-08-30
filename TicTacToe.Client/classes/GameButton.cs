using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Drawing;

namespace TicTacToe.Client
{
    class GameButton : System.Windows.Controls.Button
    {
        const int MAXBOARDSIZE = 5;
        const int MINBOARDSIZE = 4;
        const int MAX_BOARD_BUTTON_SIZE = 90;
        const int MIN_BOARD_BUTTON_SIZE = 115;
        public int boardSize { get; set; }
        public int row { get; set; }
        public int col { get; set; }



        public GameButton(int boardSize, int row,int col)
        {
            this.boardSize = boardSize;
            this.row = row;
            this.col = col;
            this.Background = new SolidColorBrush(Colors.LightGreen);
            this.FontSize = 50;
            

            this.Height = boardSize == MINBOARDSIZE ? MIN_BOARD_BUTTON_SIZE : MAX_BOARD_BUTTON_SIZE;
            this.Width = boardSize == MINBOARDSIZE ? MIN_BOARD_BUTTON_SIZE : MAX_BOARD_BUTTON_SIZE;
            this.SetValue(Grid.RowProperty, row);
            this.SetValue(Grid.ColumnProperty, col);            
        }

    }
}
