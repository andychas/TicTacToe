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
    public partial class ShowCityImageForm : Form
    {
        private string p;

        public ShowCityImageForm(Image img)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.BackgroundImage = img;            
            InitializeComponent();
        }


    }
}
