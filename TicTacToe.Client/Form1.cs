using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Client.ServiceReference;
using System.ServiceModel;


namespace TicTacToe.Client
{
    public partial class Form1 : Form
    {
        public static Form1 MainUI { get; set; }
        public Form1()
        {
            InitializeComponent();
            MainUI = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InstanceContext context = new InstanceContext(new MyCallBack());
            ServiceClient c = new ServiceClient(context);
            c.GetData(1, 2);
            
   
        }
        private class MyCallBack : IServiceCallback
        {
            public void Result(int res)
            {
                MainUI.label1.Text = res.ToString();
            }
        }
    }
}
