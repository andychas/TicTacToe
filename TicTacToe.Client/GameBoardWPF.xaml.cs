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
        private ServiceClient c = new ServiceClient();

        private enum Turn { Player, Computer};

        private int boardSize = 0;
        private int currentTurn;
        private bool isWinner = false;
        private string computerOrPlayer;
        private static Button[,] buttons;

        public GameBoardWPF(int size, string gameOption)
        {
            InitializeComponent();
            
            boardSize = size;
            computerOrPlayer = gameOption;
            currentTurn = (int)Turn.Player;

            buttons = CreateButtons();

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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameButton button = (GameButton)sender;
            string sign;
            if(computerOrPlayer.Equals("computer"))
            {
                // player move
                sign = c.NewTurn(button.col, button.row);
                moveGame(button, sign);
                currentTurn = (int)Turn.Computer;
                
                // computer move 
                int rndCol = 0;
                int rndRow = 0;
                getRandomButton(ref rndCol, ref rndRow);
                button = (GameButton)buttons[rndCol, rndRow];
                sign = c.NewTurn(button.col, button.row);
                moveGame(button, sign);
                currentTurn = (int)Turn.Player;
            }            
        }

        private void moveGame(GameButton button, string sign)
        {
            sign = c.NewTurn(button.col, button.row);
            button.Content = sign;
            button.FontSize = 20;
            button.IsEnabled = false;
            isWinner = c.IfWinner(sign, button.row, button.col);
            if (isWinner)
            {
                MessageBox.Show(sign + " is winner");
                resetGame();
            }
        }

        private void getRandomButton(ref int col, ref int row)
        {
            Random rnd = new Random();
            while (true)
            {
                int i = rnd.Next(0, boardSize);
                int j = rnd.Next(0, boardSize);
                if (buttons[i, j].IsEnabled == true)
                {
                    col = i;
                    row = j;
                    break;
                }
            }
        }

        private GameButton[,] CreateButtons()
        {
            GameButton[,] buttons = new GameButton[boardSize, boardSize];
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

        public void resetGame()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    buttons[i, j].Content = "";
                    buttons[i, j].IsEnabled = true;
                }
            }
            c.ResetGame();
        }

        /*private class MyCallBack : IServiceCallback
        {
            public void Result(int col, int row, string msg)
            { 
                GameBoardWPF.buttons[col, row].Content = "" + msg;
            }
        }*/
    }
}
