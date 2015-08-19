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
    public partial class GameBoardWPF : UserControl,IServiceCallback
    {
        

        ServiceClient c; 
        //private static enum Turn { Player1, Player2, Computer};

        private static string currenTurn;

        private static Button[,] buttons1;
        private static Button[,] buttons2;
        private string computerOrPlayer;
        private bool confirmationRequired;
        public char sign;
       
        private int boardSize = 0;
        //private int currentTurn;
        
        private static bool isWinner = false;
        private int size;
        private string gameOption;
        private Player player1;
        public Player player2;

        public GameBoardWPF(int size, string gameOption, Player player1, Player player2, bool confirmationRequired)
        {
            c = new ServiceClient(new InstanceContext(this));
            this.size = size;
            this.gameOption = gameOption;
            this.player1 = player1;
            this.player2 = player2;
            this.confirmationRequired = confirmationRequired;
            InitializeComponent();
            boardSize = size;
            computerOrPlayer = gameOption;
            currenTurn = "player1";

            buttons1 = CreateButtons();
            buttons2 = CreateButtons();

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
                    
                    grid.Children.Add(buttons1[row, col]);
                }
            }

            if (!computerOrPlayer.Equals("computer") && !confirmationRequired) // if vs player - we need the other player to confirm the duel
            {
                busyIndicator.IsBusy = true;
                c.AskPlayerConfirmation(size,player1, player2,true);

            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameButton button = (GameButton)sender;
            string sign;
            if(computerOrPlayer.Equals("computer")) // player1 vs computer
            {
                // player move
                sign = c.NewTurn(button.col, button.row);
                moveGame(button, sign);
                if (fullBoard())
                {
                    MessageBox.Show(" no winner");
                    resetGame();
                }
                else
                {
                    currenTurn = "computer";
                }
                
                
                // computer move 
                int rndCol = 0;
                int rndRow = 0;
                getRandomButton(ref rndCol, ref rndRow);
                button = (GameButton)buttons1[rndCol, rndRow];
                sign = c.NewTurn(button.col, button.row);
                moveGame(button, sign);
                if (fullBoard())
                {
                    MessageBox.Show(" no winner");
                    resetGame();
                }
                else
                {
                    currenTurn = "player1";
                }
                
            }
            else // player1 vs player2
            {
                int row = button.row;
                int col = button.col;
                if(currenTurn.Equals("player1"))
                {
                    // player 1
                    sign = c.NewTurn(button.col, button.row);
                    moveGame(button, sign);
                    buttons2[button.row, button.col].IsEnabled = false;
                    buttons2[button.row, button.col].Content = sign;
                    currenTurn = "player2";
                }
                else
                {
                    // player 2
                    sign = c.NewTurn(button.col, button.row);
                    moveGame(button, sign);
                    buttons1[button.row, button.col].IsEnabled = false;
                    buttons1[button.row, button.col].Content = sign;
                    currenTurn = "player1";
                }         
            }
        }

        private void moveGame(GameButton button, string sign)
        {
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
                if (buttons1[i, j].IsEnabled == true)
                {
                    col = i;
                    row = j;
                    break;
                }
            }
        }

        private bool fullBoard()
        {
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    if(buttons1[i,j].IsEnabled)
                    {
                        return false;
                    }
                }
            }
            return true;
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
                    buttons1[i, j].Content = "";
                    buttons2[i, j].Content = "";
                    buttons1[i, j].IsEnabled = true; 
                    buttons2[i, j].IsEnabled = true;
                }
            }
            isWinner = false;
            c.ResetGame();
        }

        private void grid_ContextMenuClosing(object sender, ContextMenuEventArgs e)
        {
            
            
        }

        public void UpdateClientBoard(int col, int row)
        {
            throw new NotImplementedException();
        }

        public void ConfirmPlayer(int gameSize, Player player1, Player player2, bool confirm)
        {
            throw new NotImplementedException();
        }

        public void StartGame()
        {
            throw new NotImplementedException();
        }


        public void StartGame(bool isYourTurn)
        {
            throw new NotImplementedException();
        }


        public void StartGame(bool isYourTurn, char sign)
        {
            throw new NotImplementedException();
        }
    }
}