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

namespace TicTacToe.Client
{
    public partial class RegisterForm : Form
    {
        private ServiceClient c = new ServiceClient();
        private bool ifValidPlayerName = false;
        private bool[] ifValidAdvisorsName;
        private List<GroupBox> AdvisorPanels = new List<GroupBox>();
        private List<TextBox> advisorsTextBoxes = new List<TextBox>();
        private int numOfAdvisors;
        private Player player;
        private List<Advisor> advisors = new List<Advisor>();
        public static RegisterForm registerForm { get; set; }
        public RegisterForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            advisorsTextBoxes = addAllTextBoxes();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
                    if (!ifValidAdvisorsName[i]){
                        advisors = null;
                        return;
                    }
                    else
                    {
                        Advisor a = new Advisor();
                        a.First_Name = advisorsTextBoxes.ElementAt(i).Text;
                        a.Last_Name =  advisorsTextBoxes.ElementAt(i+1).Text;
                        advisors.Add(a);                     
                    }
                }
                
                c.AddPlayer(playerFirstName.Text, playerLastName.Text);
                GameInfoForm gameInfo = new GameInfoForm(playerFirstName.Text, playerLastName.Text);
                gameInfo.Show();
                player = c.GetPlayer(playerFirstName.Text, playerLastName.Text);
                c.AddAdvisor(player, advisors.ToArray());
                               
            }       
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            AdvisorPanels.Add(AdvisorGroup1);
            AdvisorPanels.Add(AdvisorGroup2);
            AdvisorPanels.Add(AdvisorGroup3);
            for (int i = 0; i < AdvisorPanels.Count; i++)
            {
                AdvisorPanels.ElementAt(i).Visible = false;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
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

        private void Advisor_Validating(object sender, CancelEventArgs e)
        {
            ifValidAdvisorsName = new bool[numOfAdvisors];

            int i = 0;
            while(i < numOfAdvisors * 2)
            {
                if (ValidName(advisorsTextBoxes.ElementAt(i).Text))
                {
                    errorProvider2.Dispose();
                    ifValidAdvisorsName[i/2] = true;
                }

                else
                {
                    ifValidAdvisorsName[i/2] = false;
                    errorProvider2.SetError(advisorsTextBoxes.ElementAt(i), "Error");
                }
                i = i + 2;
            } 
        }
    }
}
