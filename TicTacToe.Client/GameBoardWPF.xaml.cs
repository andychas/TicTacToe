using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TicTacToe.Client.ServiceReference1;
using System.ServiceModel;

namespace TicTacToe.Client
{
    /// <summary>
    /// Interaction logic for GameBoard4x4.xaml
    /// </summary>
    public partial class GameBoardWPF : UserControl
    {
        private int boardSize = 0;
        enum  sign {X,O,};
        public GameBoardWPF(int size)
        {
            boardSize = size;

            InitializeComponent();

            GameButton[,] buttons = CreateButtons();

            for (int i = 0; i < size; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());

            }
            for (int i = 0; i < size; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());

            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {

                    grid.Children.Add(buttons[row, col]);
                }
            }
/*

 */
            

        }

        private GameButton[,] CreateButtons()
        {
            GameButton[,] buttons = new GameButton[boardSize,boardSize];
            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {
                    
                    buttons[row, col] = new GameButton(boardSize, row, col);
                    buttons[row, col].VerticalAlignment = VerticalAlignment.Center;
                    buttons[row, col].Click += Button_Click;
                }
            }
            return buttons;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            GameButton b = (GameButton)sender;
            b.Content = "Clicked";
            ServiceClient c = new ServiceClient();
           // c.AddTurn(b.col, b.row, b.boardSize);

           
            
        }
    }
}
