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
using System.ServiceModel;
using System.Windows.Forms.Integration;

namespace TicTacToe.Client
{
    public partial class TicTacToeForm : Form, IServiceCallback
    {
        #region Private Fields
        private ServiceClient c ;
        private Player player1;
        private Player player2;        
        private int size = 4;
        private string gameOption = "computer";
        private bool confirmation;
        private string championship = "";
        private int champId;
        private GameBoardWPF gameboard;

        private bool ifValidPlayerName = false;
        private bool[] ifValidAdvisorsName;
        private List<GroupBox> AdvisorPanels = new List<GroupBox>();
        private List<TextBox> advisorsTextBoxes = new List<TextBox>();
        private int numOfAdvisors;
        private Player player;
        private List<Advisor> advisors = new List<Advisor>();
#endregion

        #region Constructor
        public TicTacToeForm()
        {
            InitializeComponent();
            c = new ServiceClient(new InstanceContext(this));
            PlayBtn.Enabled = false;
        }
        #endregion

        #region MainForm
        private void TicTacToeForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            RegisterPanel.Visible = false;
            GameBoardPanel.Visible = false;
            GameInfoPanel.Visible = false;
            GetPlayers();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlayBtn.Enabled = true;
        }

        private void TicTacToeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            c.removeClient();
        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            bool isRegistered;
            string[] playerInfo = comboBox1.Text.Split(' ');
            player1 = c.GetPlayer(playerInfo[0], playerInfo[1]);
            if (player1 != null)
            {
                isRegistered = c.RegisterClient(player1);
                if (isRegistered)
                {
                    initGameInfoPanel();
                    RegisterPanel.Visible = true;
                    GameInfoPanel.Visible = true;
                }
                else
                {
                    MessageBox.Show("Error registering player, This player might be already online");
                }
            }
            else
            {

            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterPanel.Visible = true;
        }

        #endregion

        #region GameBoardPanel
        private void newGameBtn_Click(object sender, EventArgs e)
        {
            //elementHost1.Child = new GameBoardWPF(size, gameOption, player1, player2, confirmation);
            
        }
        #endregion

        #region GameInfoPanel
        private void smallBoardButton_CheckedChanged(object sender, EventArgs e)
        {
            size = 4;
        }

        private void bigBoardButton_CheckedChanged(object sender, EventArgs e)
        {
            size = 5;
        }

        private void computerButton_CheckedChanged(object sender, EventArgs e)
        {
            gameOption = "computer";
            playersComboBox.Enabled = false;
            StartGameBtn.Text = "Start Game";
        }

        private void playerButton_CheckedChanged(object sender, EventArgs e)
        {
            gameOption = "player";
            playersComboBox.Enabled = true;
            StartGameBtn.Text = "Duel Player";
        }

        private void playersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] playerInfo = playersComboBox.Text.Split(' ');
            player2 = c.GetPlayer(playerInfo[0], playerInfo[1]);
        }

        private void ChampComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            championship = ChampComboBox.Text;
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            if (gameOption == "computer") // vs computer
            {
                gameboard = new GameBoardWPF(size, gameOption, player1, player2, confirmation);
                elementHost1.Child = gameboard;

                
            }
            else                          // vs player
            {
                c.AskPlayerConfirmation(size, player1, player2, true);
                gameboard = new GameBoardWPF(size, gameOption, player1, player2, confirmation);
                elementHost1.Child = gameboard;

            }
            GameBoardPanel.Visible = true;
            GameInfoPanel.Visible = true;
            c.GameInfo(size, gameOption);
        }
        #endregion

        #region RegisterPanel
        private void AdvisorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            numOfAdvisors = Int32.Parse(AdvisorComboBox.Text);
            for (int i = 0; i < AdvisorPanels.Count(); i++)
            {
                if (i < numOfAdvisors)
                {
                    AdvisorPanels.ElementAt(i).Visible = true;
                }
                else
                {
                    AdvisorPanels.ElementAt(i).Visible = false;
                }
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (ifValidPlayerName)
            {
                for (int i = 0; i < numOfAdvisors; i++)
                {
                    if (!ifValidAdvisorsName[i])
                    {
                        advisors = null;
                        return;
                    }
                    else
                    {
                        Advisor a = new Advisor();
                        a.First_Name = advisorsTextBoxes.ElementAt(i).Text;
                        a.Last_Name = advisorsTextBoxes.ElementAt(i + 1).Text;
                        advisors.Add(a);
                    }
                }
                player = c.GetPlayer(playerFirstName.Text, playerLastName.Text);
                c.AddPlayer(playerFirstName.Text, playerLastName.Text);

                c.AddAdvisor(player, advisors.ToArray());
                initGameInfoPanel();
                RegisterPanel.Visible = false;
                GameInfoPanel.Visible = true;

            }
        }

        private void playerFirstName_Validating(object sender, CancelEventArgs e)
        {
            player = c.GetPlayer(playerFirstName.Text, playerLastName.Text);
            if ((ValidName(playerFirstName.Text)) && (player == null))
            {
                ifValidPlayerName = true;
                errorProvider1.Dispose();
            }
            else
            {
                ifValidPlayerName = false;
                errorProvider1.SetError(playerFirstName, "Error");
            }
        }

        private void Advisor_Validating(object sender, CancelEventArgs e)
        {
            ifValidAdvisorsName = new bool[numOfAdvisors];

            int i = 0;
            while (i < numOfAdvisors * 2)
            {
                if (ValidName(advisorsTextBoxes.ElementAt(i).Text))
                {
                    errorProvider2.Dispose();
                    ifValidAdvisorsName[i / 2] = true;
                }

                else
                {
                    ifValidAdvisorsName[i / 2] = false;
                    errorProvider2.SetError(advisorsTextBoxes.ElementAt(i), "Error");
                }
                i = i + 2;
            }
        }
        #endregion

        #region Help Methods
        private void GetPlayers()
        {
            Player[] players = c.GetPlayers();
            foreach (Player player in players)
            {
                comboBox1.Items.Add(player.First_Name + " " + player.Last_Name);


            }
        }

        private void initGameInfoPanel()
        {
            Player[] players = c.GetPlayers();
            foreach (Player player in players)
            {
                if ((!player.First_Name.Equals(player1.First_Name)) || (!player.Last_Name.Equals(player1.Last_Name)))
                {
                    playersComboBox.Items.Add(player.First_Name + " " + player.Last_Name);
                }
            }

            Championship[] championships = c.GetChampionships();
            foreach (Championship champ in championships)
            {
                ChampComboBox.Items.Add(champ.Id + " " + champ.City);
            }
        }

        private List<TextBox> addAllTextBoxes()
        {
            List<TextBox> t = new List<TextBox>();
            t.Add(advisor1FirstName);
            t.Add(advisor1LastName);
            t.Add(advisor2FirstName);
            t.Add(advisor2LastName);
            t.Add(advisor3FirstName);
            t.Add(advisor3LastName);
            return t;
        }

        public bool ValidName(string name)
        {
            if (name.Length < 1)
            {
                return false;
            }
            if (name.Any(c => char.IsDigit(c)))
            {
                return false;
            }
            return true;
        }

        #endregion

        #region Service Callbacks

        public void UpdateClientBoard(int col, int row)
        {
            throw new NotImplementedException();
        }

        public void ConfirmPlayer(int gameSize, Player p1, Player p2, bool confirmationRequired)
        {
            DialogResult dialogResult = MessageBox.Show(p2.First_Name + ": " + p1.First_Name + " wants to play against you ", "Confirmation", MessageBoxButtons.YesNo);
            player2 = p1;
            if (dialogResult == DialogResult.Yes)
            {

                gameboard = new GameBoardWPF(size, gameOption, p2, p1, confirmation);
                elementHost1.Child = gameboard;

                c.playerConfirmed(p1,p2);
                GameBoardPanel.Visible = true;
                GameInfoPanel.Visible = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        public void StartGame(bool isYourTurn, char sign)
        {
            gameboard.sign = sign;
            if (gameboard.busyIndicator.IsBusy)
            {
                gameboard.busyIndicator.IsBusy = false;
                MessageBox.Show("Your Turn");
            }
            else
            {
                gameboard.busyIndicator.IsBusy = true;
            }

            if (isYourTurn)
            {

            }
        }
        #endregion








    }
}
