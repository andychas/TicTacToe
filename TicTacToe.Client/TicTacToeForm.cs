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
        const int DB_DELAY = 3000;
        #region Private Fields
        private ServiceClient c;
        private DataGridViewRow row;
        private List<DataGridViewRow> rows = new List<DataGridViewRow>();
        private List<GroupBox> AdvisorPanels = new List<GroupBox>();
        private List<TextBox> advisorsTextBoxes = new List<TextBox>();
        private List<Advisor> advisors = new List<Advisor>();
        private GameBoardWPF gameboard;
        private Player player;
        private Player player1;
        private Player player2;
        private string gameOption = "computer";
        private string championship = "";
        private bool[] ifValidAdvisorsName;
        private bool confirmation;
        private bool ifValidPlayerName = false;

        private int champId;
        private int gameId;
        private int size = 4;
        private int numOfAdvisors;
        private int delay = 0;
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
            // TODO: This line of code loads data into the 'databaseDataSet.Championship' table. You can move, or remove it, as needed.
            //this.championshipTableAdapter.Fill(this.databaseDataSet.Championship);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = System.Drawing.Color.Aquamarine;
            RegisterPanel.Visible = false;
            GameBoardPanel.Visible = false;
            GameInfoPanel.Visible = false;
            GetPlayers();
            AdvisorPanels.Add(AdvisorGroup1);
            AdvisorPanels.Add(AdvisorGroup2);
            AdvisorPanels.Add(AdvisorGroup3);

            groupBox5.Text = "";

            PictureBox p1 = new PictureBox();
            p1.Width = 600;
            p1.Height = 200;
            p1.SizeMode = PictureBoxSizeMode.StretchImage;
            p1.Image = Properties.Resources.logo;
            p1.Location = new Point(30,280);

            PictureBox p2 = new PictureBox();
            p2.Width = 170;
            p2.Height = 170;
            p2.SizeMode = PictureBoxSizeMode.StretchImage;
            p2.Image = Properties.Resources.tictactoe;
            p2.Location = new Point(500, 60);

            PictureBox p3 = new PictureBox();
            p3.Width = 170;
            p3.Height = 170;
            p3.SizeMode = PictureBoxSizeMode.StretchImage;
            p3.Image = Properties.Resources.tictactoe;
            p3.Location = new Point(25, 60);

            this.Controls.Add(p1);
            this.Controls.Add(p2);
            this.Controls.Add(p3);

            for (int i = 0; i < AdvisorPanels.Count; i++)
            {
                AdvisorPanels.ElementAt(i).Visible = false;
            }
            advisorsTextBoxes = addAllTextBoxes();
           

            
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
            player1 = c.GetPlayer(playerInfo[1], playerInfo[2]);
            if (player1 != null)
            {
                isRegistered = c.RegisterClient(player1);
                loadGameInfoPanel();
                if (isRegistered)
                { 
                    RegisterPanel.Visible = true;
                    GameInfoPanel.Visible = true;
                    playersComboBox.Enabled = false;
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

        #region Menu

        private void  allPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllPlayers allPlayersForm = new AllPlayers(delay);
            allPlayersForm.Show();
        }

        private void allGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllGamesForm games = new AllGamesForm(delay);
            games.Show();
        }

        private void allChampionshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllChampionshipsForm championshipsForm = new AllChampionshipsForm(delay);
            championshipsForm.Show();
        }

        private void allPlayerGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameForPlayerForm form = new GameForPlayerForm(delay);
            form.Show();
        }

        private void allPlayerChampionshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChampForPlayerForm form = new ChampForPlayerForm(delay);
            form.Show();
        }

        private void allPlayersInGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayerForGameForm form = new PlayerForGameForm(delay);
            form.Show();
        }

        private void allPlayersInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PlayersForChampForm form = new PlayersForChampForm(delay);
            form.Show();
        }

        private void numberOfChampionshipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumOfChampForm form = new NumOfChampForm(delay);
            form.Show();
        }

        private void numberOfGamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NumOfGamesForm form = new NumOfGamesForm(delay);
            form.Show();
        }

        private void allAdvisorsInGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvisorForGameForm form = new AdvisorForGameForm(delay);
            form.Show();
        }

        private void abuotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            c.removeClient();
            Application.Exit();
        }

        private void yesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delay = DB_DELAY;
            delayToolStripMenuItem.Text = "DB Delay On";
        }

        private void noToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delay = 0;
            delayToolStripMenuItem.Text = "DB Delay Off";
        }

        #endregion

        #region GameBoardPanel

        private void backBtn_Click(object sender, EventArgs e)
        {
            GameBoardPanel.Visible = false;
            loadGameInfoPanel();
        }

        private void newGameBtn_Click(object sender, EventArgs e)
        {
            gameId = c.AddGame(champId, player1, player2, size);
            gameboard = new GameBoardWPF(gameId, size, gameOption, player1, player2, confirmation);
            elementHost1.Child = gameboard;
            c.AddAdvisor(player1, advisors.ToArray(), gameId);
            c.GameInfo(size, gameOption);
            
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
            champId = Convert.ToInt32(championship.Substring(0, championship.IndexOf(' ')));
        }

        private void playersComboBox_DropDown(object sender, EventArgs e)
        {
            playersComboBox.Items.Clear();
            Player[] players = c.GetOnlinePlayers();
            foreach (Player player in players)
            {
                if ((!player.First_Name.Equals(player1.First_Name)) || (!player.Last_Name.Equals(player1.Last_Name)))
                {
                    playersComboBox.Items.Add(player.First_Name + " " + player.Last_Name);
                }
            }
        }

        private void ChampComboBox_DropDown(object sender, EventArgs e)
        {
            ChampComboBox.Items.Clear();
            Championship[] championships = c.GetChampionships();
            foreach (Championship champ in championships)
            {
                ChampComboBox.Items.Add(champ.Id + " " + champ.City);
            }
        }

        private void recordGame_DropDown(object sender, EventArgs e)
        {
            recordGame.Items.Clear();
            int[] games = c.GetRecordGameId();
            foreach (int id in games)
            {
                recordGame.Items.Add(id);
            }
        }

        private void StartGameBtn_Click(object sender, EventArgs e)
        {
            if(!recordGame.Text.Equals("")) // select recordGame id
            {
                gameId = Convert.ToInt32(recordGame.Text);
                GameMove[] moves = c.GetGameMoves(gameId);

                gameboard = new GameBoardWPF(gameId, moves, confirmation);
                elementHost1.Child = gameboard;
            }
            else
            {
                gameId = c.AddGame(champId, player1, player2, size);
                c.AddPlayerToChamp(player1, champId);
                if (gameOption == "computer") // vs computer
                {
                    gameboard = new GameBoardWPF(gameId, size, gameOption, player1, player2, confirmation);
                    elementHost1.Child = gameboard;
                }
                else                          // vs player
                {
                    gameboard = new GameBoardWPF(gameId, size, gameOption, player1, player2, confirmation);
                    elementHost1.Child = gameboard;
                }
                c.AddAdvisor(player1, advisors.ToArray(), gameId);
                c.GameInfo(size, gameOption);
            }
            GameBoardPanel.Visible = true;
            GameInfoPanel.Visible = true;    
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if ((!startDateText.Text.Equals("")) && (!endDateText.Text.Equals("")) && (!cityText.Text.Equals("")))
            {
                string city = cityText.Text.ToString();
                string imageUrl = imageText.Text.ToString();
                DateTime startDate = DateTime.Parse(startDateText.Text.ToString());
                DateTime endDate = DateTime.Parse(endDateText.Text.ToString());
                int championshipId = c.AddChampionship(startDate, endDate, city, imageUrl);
                c.AddPlayerToChamp(player1, championshipId);
            }
            loadGameInfoPanel();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            updateBtn.Enabled = true;
            row = this.dataGridView1.Rows[e.RowIndex];
            rows.Add(this.dataGridView1.Rows[e.RowIndex]);
            startDateText.Text = row.Cells["Start_Date"].Value.ToString();
            endDateText.Text = row.Cells["End_Date"].Value.ToString();
            cityText.Text = row.Cells["City"].Value.ToString();
            try
            {
                imageText.Text = row.Cells["Picture"].Value.ToString();
                pictureBox1.ImageLocation = imageText.Text;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch
            {
                imageText.Text = "";
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(row.Cells["Id"].Value.ToString());
            c.RemovePlayerToChampionship(player1, id);
            loadGameInfoPanel();

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateBtn.Enabled = false;
            int id = Int32.Parse(row.Cells["Id"].Value.ToString());
            string city = cityText.Text.ToString();
            string imageUrl = imageText.Text.ToString();
            DateTime startDate = DateTime.Parse(startDateText.Text.ToString());
            DateTime endDate = DateTime.Parse(endDateText.Text.ToString());
            c.UpdateChampionship(id, startDate, endDate, city, imageUrl);
            loadGameInfoPanel();
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
                int b = 0;
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
                        a.First_Name = advisorsTextBoxes.ElementAt(b++).Text;
                        a.Last_Name = advisorsTextBoxes.ElementAt(b++).Text;
                        advisors.Add(a);
                    }
                }
                player = c.GetPlayer(playerFirstName.Text, playerLastName.Text);
                player1 = c.AddPlayer(playerFirstName.Text, playerLastName.Text);
                loadGameInfoPanel();
                RegisterPanel.Visible = true;
                GameInfoPanel.Visible = true;
                playersComboBox.Enabled = false;
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
                comboBox1.Items.Add(player.Id + " " + player.First_Name + " " + player.Last_Name);
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

        private void loadGameInfoPanel()
        {
            bindingSource1.DataSource = c.GetChampionshipsByPlayerId(player1);
            dataGridView1.DataSource = bindingSource1;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.MultiSelect = true;
        }

        #endregion

        #region Service Callbacks

        public void UpdateClientBoard(int col, int row)
        {
            throw new NotImplementedException();
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


        }

        public void MakeYourTurn(int row, int col)
        {
            char s;
            if (gameboard.sign == 'X')
                s = 'O';
            else
                s = 'X';
            gameboard.busyIndicator.IsBusy = false;        
            gameboard.buttons1[row, col].Content = s;
            gameboard.buttons1[row, col].FontSize = 20;
            gameboard.buttons1[row, col].IsEnabled = false;

            
            
        }

        public void ConfirmPlayer(int gameSize, Player p1, Player p2, bool confirmationRequired, int gameId)
        {
            DialogResult dialogResult = MessageBox.Show(p2.First_Name + ": " + p1.First_Name + " wants to play against you ", "Confirmation", MessageBoxButtons.YesNo);
            player2 = p1;
            if (dialogResult == DialogResult.Yes)
            {

                gameboard = new GameBoardWPF(gameId, size, "player", p2, p1, confirmationRequired);

                elementHost1.Child = gameboard;

                c.playerConfirmed(p1, p2);
                GameBoardPanel.Visible = true;
                GameInfoPanel.Visible = true;
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }


        public void GameWon(string sign)
        {
            MessageBox.Show("Player " + sign + " is a Winner");
            GameBoardPanel.Visible = false;
            loadGameInfoPanel();

        }

        public void GameTied()
        {
            MessageBox.Show("Game Is Tied");
            GameBoardPanel.Visible = false;
            loadGameInfoPanel();
        }

        #endregion 

        

        

    }
}
