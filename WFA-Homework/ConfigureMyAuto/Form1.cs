using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigureMyAuto
{
    public partial class Form1 : Form
    {
        int mercedes = 223000;
        int bmw = 165000;
        int audi = 178000;
        int abs = 150;
        int fog = 75;
        int parktronik = 125;
        double price;
        double discount;
        double total;
        double final;
        double finalPrice;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbTotal.Clear();
            tbDiscount.Clear();
            tbFinalPrice.Clear();
            
        }

        private void rbAudi_CheckedChanged(object sender, EventArgs e)
        {
            pbCars.Image = ConfigureMyAuto.Properties.Resources.audi;
            if (rbAudi.Checked)
            {
                tbCarPrice.Text = audi.ToString();
            }
        }

        private void rbBMW_CheckedChanged(object sender, EventArgs e)
        {
            pbCars.Image = ConfigureMyAuto.Properties.Resources.bmw;
            if (rbBMW.Checked)
            {
                tbCarPrice.Text = bmw.ToString();
            }
        }

        private void rbMercedes_CheckedChanged(object sender, EventArgs e)
        {
            
            pbCars.Image = ConfigureMyAuto.Properties.Resources.mercedes;
            if (rbMercedes.Checked)
            {
                tbCarPrice.Text = mercedes.ToString();
            }

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbAudi.Checked == true)
            {
                
                total = audi;
                tbTotal.Text = total.ToString();
            }
            else if (rbBMW.Checked == true)
            {
                total = bmw;
                tbTotal.Text = total.ToString();
            }
            else if (rbMercedes.Checked == true)
            {
                total = mercedes;
                tbTotal.Text = total.ToString();
            }
            if (cbABS.Checked==true)
            {
                total = total + abs;
                tbTotal.Text = total.ToString();
            }
            if (cbFog.Checked == true)
            {
                total = total + fog;
                tbTotal.Text = total.ToString();
            }
            if (cbParktronik.Checked == true)
            {
                total = total + parktronik;
                tbTotal.Text = total.ToString();
            }
            if (cbABS.Checked && cbFog.Checked && cbParktronik.Checked)
            {
                price = total + abs + fog + parktronik;
                discount = price*0.10;
                total = price - discount;
                tbTotal.Text = total.ToString();
                
            }
        }

        private void cbABS_CheckedChanged(object sender, EventArgs e)
        {
            int value = abs;
        }

        private void cbFog_CheckedChanged(object sender, EventArgs e)
        {
            int value = fog;
        }

        private void cbParktronik_CheckedChanged(object sender, EventArgs e)
        {
            int value = parktronik;
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (rbAudi.Checked == true)
            {

                total = audi;
            }
            else if (rbBMW.Checked == true)
            {
                total = bmw;
            }
            else if (rbMercedes.Checked == true)
            {
                total = mercedes;
            }
            if (cbABS.Checked && cbFog.Checked && cbParktronik.Checked)
            {
                price = total + abs + fog + parktronik;
                discount = price * 0.10;
                total = price-discount;
                final = price - total;
                tbDiscount.Text = final.ToString();

            }
            else
            {
                final = 0;
                tbDiscount.Text = final.ToString();
            }
            
        }

        private void btnFinalPrice_Click(object sender, EventArgs e)
        {
            if (rbAudi.Checked == true)
            {

                total = audi;
            }
            else if (rbBMW.Checked == true)
            {
                total = bmw;
            }
            else if (rbMercedes.Checked == true)
            {
                total = mercedes;
            }
            if (cbABS.Checked == true)
            {
                total = total + abs;
                //tbFinalPrice.Text = total.ToString();
            }
            if (cbFog.Checked == true)
            {
                total = total + fog;
               // tbFinalPrice.Text = total.ToString();
            }
            if (cbParktronik.Checked == true)
            {
                total = total + parktronik;
                //tbFinalPrice.Text = total.ToString();
            }
            if (cbABS.Checked && cbFog.Checked && cbParktronik.Checked)
            {
                price = total + abs + fog + parktronik;
                discount = price * 0.10;
                total = price - discount;
                //tbFinalPrice.Text = total.ToString();

            }
            if (cbCreditCard.Checked == true&&cbCheck.Checked==false && cbCash.Checked==false)
            {

               

                tbFinalPrice.Text = total.ToString();
            }
            if (cbCreditCard.Checked == false && cbCheck.Checked == true && cbCash.Checked == false)
            {
                
                

                tbFinalPrice.Text = total.ToString();
            }
            if (cbCreditCard.Checked == false && cbCheck.Checked == false && cbCash.Checked == true)
            {
                finalPrice = total * 0.05;
                finalPrice = total - finalPrice;
                tbFinalPrice.Text = finalPrice.ToString();
            }
        }
    }
}
