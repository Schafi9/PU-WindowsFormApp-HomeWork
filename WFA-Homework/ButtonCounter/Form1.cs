using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonCounter
{
    public partial class Form1 : Form
    {
        int count = 0;
        public Form1()
        {
            InitializeComponent();
            lblCount.Text = " 0 ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblCount.Text = "0 ";
            count = 0;
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            count++;
            lblCount.Text = count.ToString();
            switch (count)
            {
                case 5:
                    this.BackColor = Color.DarkSeaGreen; break;
                case 10:
                    this.BackColor = Color.LightSkyBlue; break;
                case 15:
                    this.BackColor = Color.OrangeRed; break;
                default:
                    this.BackColor = DefaultBackColor; break;
            }
        }
    }
}
