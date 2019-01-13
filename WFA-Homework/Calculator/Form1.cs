using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        string operand1 = string.Empty;
        string operand2 = string.Empty;
        string result;
        char operation;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Click += new EventHandler(btn_Click);
            btn2.Click += new EventHandler(btn_Click);
            btn3.Click += new EventHandler(btn_Click);
            btn4.Click += new EventHandler(btn_Click);
            btn5.Click += new EventHandler(btn_Click);
            btn6.Click += new EventHandler(btn_Click);
            btn7.Click += new EventHandler(btn_Click);
            btn8.Click += new EventHandler(btn_Click);
            btn9.Click += new EventHandler(btn_Click);
            btn0.Click += new EventHandler(btn_Click);
            btnPoint.Click += new EventHandler(btn_Click);
        }

        private void tbCalculation_TextChanged(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '+': 
                    //case '-': 
                    //case '*': 
                    //case '/': 
                    //case '.': 
                    break;
                default:
                    e.Handled = true;
                    MessageBox.Show("Only numbers, +, -, ., *, / are allowed");
                    break;
            }
        }
        void btn_Click(object sender, EventArgs e)
        {
                Button btn = sender as Button;

                switch (btn.Name)
                {
                    case "btn1":
                        tbCalculation.Text += "1";
                        break;
                    case "btn2":
                        tbCalculation.Text += "2";
                        break;
                    case "btn3":
                        tbCalculation.Text += "3";
                        break;
                    case "btn4":
                        tbCalculation.Text += "4";
                        break;
                    case "btn5":
                        tbCalculation.Text += "5";
                        break;
                    case "btn6":
                        tbCalculation.Text += "6";
                        break;
                    case "btn7":
                        tbCalculation.Text += "7";
                        break;
                    case "btn8":
                        tbCalculation.Text += "8";
                        break;
                    case "btn9":
                        tbCalculation.Text += "9";
                        break;
                    case "btn0":
                        tbCalculation.Text += "0";
                        break;
                    case "btnPoint":
                        if (!tbCalculation.Text.Contains("."))
                            tbCalculation.Text += ".";
                        break;

                }
            
        }
        private void btnD_Click(object sender, EventArgs e)
        {
            operand1 = tbCalculation.Text;
            operation = '/';
            tbCalculation.Text = string.Empty;
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operand1 = tbCalculation.Text;
            operation = '*';
            tbCalculation.Text = string.Empty;
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            operand1 = tbCalculation.Text;
            operation = '-';
            tbCalculation.Text = string.Empty;
        }

        private void btnAssembly_Click(object sender, EventArgs e)
        {
            operand1 = tbCalculation.Text;
            operation = '+';
            tbCalculation.Text = string.Empty;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbCalculation.Text = string.Empty;
            operand1 = string.Empty;
            operand2 = string.Empty;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            operand2 = tbCalculation.Text;

            double opr1, opr2;
            double.TryParse(operand1, out opr1);
            double.TryParse(operand2, out opr2);

            switch (operation)
            {
                case '+':
                    result = (opr1 + opr2).ToString();
                    break;

                case '-':
                    result = (opr1 - opr2).ToString();
                    break;

                case '*':
                    result = (opr1 * opr2).ToString();
                    break;

                case '/':
                    if (opr2 != 0)
                    {
                        result = (opr1 / opr2).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Can't divide by zero");
                    }
                    break;
            }

            tbCalculation.Text = result.ToString();
        }
    }
    
}
