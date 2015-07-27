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
        private bool isWinner = false;
        private static Button[,] buttons;
        public GameBoardWPF(int size)
        {
            boardSize = size;
            InitializeComponent();
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
            //InstanceContext context = new InstanceContext(new MyCallBack());
            //ServiceClient c = new ServiceClient(context);
            ServiceClient c = new ServiceClient();
            string sign = c.NewTurn(b.col, b.row);
            Console.WriteLine(sign);
            b.Content = sign;
            b.FontSize = 20;
            b.IsEnabled = false;
            isWinner = c.IfWinner(sign, b.row, b.col);
            Console.WriteLine(isWinner);
            if (isWinner)
            {
                MessageBox.Show(sign + " is winner");
            }
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
