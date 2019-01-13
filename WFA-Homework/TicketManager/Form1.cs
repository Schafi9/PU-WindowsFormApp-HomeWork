using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketManager
{
    public partial class Form1 : Form
    {
        int kids = 3;
        int students = 4;
        int collegian = 5;
        int total;
        int amountTickets;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            amountTickets = int.Parse(txtNumber.Text);
            if (rbKid.Checked)
            {
                total = amountTickets * kids;
                lblResult.Text = total.ToString();
                rbKid.Checked = false;
                txtNumber.Text = "";

            }
            else if (rbStudent.Checked)
            {
                total = amountTickets * students;
                lblResult.Text = total.ToString();
                rbStudent.Checked = false;
                txtNumber.Text = "";
            }
            else if (rbCollegian.Checked)
            {
                total = amountTickets * collegian;
                lblResult.Text = total.ToString();
                rbCollegian.Checked = false;
                txtNumber.Text = "";
            }
        }
    }
}
