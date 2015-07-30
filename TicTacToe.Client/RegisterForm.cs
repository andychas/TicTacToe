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
        private bool flag = false;
        private List<GroupBox> AdvisorPanels = new List<GroupBox>();

        public static RegisterForm registerForm { get; set; }
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numOfAdvisor = Int32.Parse(AdvisorComboBox.Text);
            for (int i = 0; i < AdvisorPanels.Count(); i++)
            {
                if(i < numOfAdvisor)
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
            if (flag)
            {
                c.AddPlayer(firstNameText.Text, lastNameText.Text);
                GameInfoForm gameInfo = new GameInfoForm(firstNameText.Text, lastNameText.Text);
                gameInfo.Show();
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
            IEnumerable<Tuple<int, string, string>> player = c.GetPlayer(firstNameText.Text, lastNameText.Text);
            if ((ValidName(firstNameText.Text)) && (player.Count() == 0))
            {
                flag = true;
                errorProvider1.Dispose();
            }
            else
            {
                flag = false;
                errorProvider1.SetError(firstNameText, "Error");
            }
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

    }
}
