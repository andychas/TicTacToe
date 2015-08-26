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
using System.Windows.Media.Animation;

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

        public Button[,] buttons1;
        public Button[,] buttons2;
        private string computerOrPlayer;
        private bool confirmationRequired;
        public char sign;
       
        private int boardSize;
        
        private static bool isWinner = false;
        //private int size;
        private int gameId;
        private string gameOption;
        private Player player1;
        private Player player2;
        private GameMove[] moves;
        private bool confirmation;

        public GameBoardWPF(int gameId, int size, string gameOption, Player player1, Player player2, bool confirmationRequired)
        {
            c = new ServiceClient(new InstanceContext(this));
            this.boardSize = size;
            this.gameId = gameId;
            this.gameOption = gameOption;
            this.player1 = player1;
            this.player2 = player2;
            this.confirmationRequired = confirmationRequired;
            InitializeComponent();
            computerOrPlayer = gameOption;
            currenTurn = "player1";

            buttons1 = CreateButtons();
            buttons2 = CreateButtons();

            initGrid();

            if (!computerOrPlayer.Equals("computer") && !confirmationRequired) // if vs player - we need the other player to confirm the duel
            {
                busyIndicator.IsBusy = true;
                c.AskPlayerConfirmation(size,player1, player2,true,gameId);

            }
        }

        public GameBoardWPF(int gameId, GameMove[] moves, bool confirmation)
        {
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            this.gameId = gameId;
            this.moves = moves;
            this.confirmation = confirmation;
            boardSize = c.GetSizeGame(gameId);

            buttons1 = CreateButtons();

            initGrid();

            for (int i = 0; i < boardSize; i++)
            {
                for(int j = 0; j < boardSize; j++)
                {
                    buttons1[i, j].IsEnabled = false;
                }
            }

            // print all moves on game board
            for (int i = 0; i < moves.Count(); i++)
            {
                int row = Convert.ToInt32(moves[i].row);
                int col = Convert.ToInt32(moves[i].col);
                string s = moves[i].Sign;
                buttons1[row, col].Content = s;
                buttons1[row, col].FontSize = 20;
                buttons1[row, col].IsEnabled = false;
            }

        }

        private void initGrid()
        {
            for (int i = 0; i < boardSize; i++)
            {
                grid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            for (int i = 0; i < boardSize; i++)
            {
                grid.RowDefinitions.Add(new RowDefinition());
            }

            for (int row = 0; row < boardSize; row++)
            {
                for (int col = 0; col < boardSize; col++)
                {

                    grid.Children.Add(buttons1[row, col]);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GameButton button = (GameButton)sender;
            string gsign;
            if(computerOrPlayer.Equals("computer")) // player1 vs computer
            {
                // player move
                gsign = c.NewTurn(button.col, button.row);
                moveGame(button, gsign);
                c.AddMove(gameId, gsign, button.row, button.col);
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
                gsign = c.NewTurn(button.col, button.row);
                moveGame(button, gsign);
                c.AddMove(gameId, gsign, button.row, button.col);
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

                button.Content = sign;
                button.FontSize = 20;
                button.IsEnabled = false;

                c.SendGameMove(player1, player2, sign, col, row,gameId);
                
                busyIndicator.IsBusy = true;
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
    }
}