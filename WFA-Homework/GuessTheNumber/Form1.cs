using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rand = new Random();
            string s = null;
            for (int i = 0; i <= 100; i++)
                s += rand.Next(0, 1001).ToString() + ",";
            MessageBox.Show(s);
        }
    }
}
