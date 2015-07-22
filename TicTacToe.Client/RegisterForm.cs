using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe.Client
{
    public partial class RegisterForm : Form
    {

        bool flag = false;
        List<Panel> AdvisorPanels = new List<Panel>();
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int numOfAdvisor = Int32.Parse(AdvisorComboBox.Text);
            for (int i = 0; i < numOfAdvisor; i++)
            {
                AdvisorPanels.ElementAt(i).Visible = true;
            }
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                GameInfoForm gameInfo = new GameInfoForm();
                gameInfo.Show();
            }
            
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            AdvisorPanels.Add(AdvisorPanel1);
            AdvisorPanels.Add(AdvisorPanel2);
            AdvisorPanels.Add(AdvisorPanel3);
            for (int i = 0; i < AdvisorPanels.Count; i++)
            {
                AdvisorPanels.ElementAt(i).Visible = false;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (ValidName(textBox1.Text))
            {
                flag = true;
                errorProvider1.Dispose();
                //insert player
            }
            else
            {
                flag = false;
                errorProvider1.SetError(textBox1, "Error");
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
