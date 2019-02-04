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
        Random rnd = new Random();
        int number = 0;
        int userNumber = 0;
        int points = 0;
        int difficulty = 0;
        string level;
        public Form1()
        {
            InitializeComponent();
        }

        private void cmLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            level = cmLevel.SelectedItem.ToString();
            if (level == "1-10")
            {
                difficulty = 10;
            }
            else if (level == "1-50")
            {
                difficulty = 50;
            }
            else if (level == "1-100")
            {
                difficulty = 100;
            }
            else if (level == "1-1000")
            {
                difficulty = 1000;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            try
            {
                number = rnd.Next(1, difficulty);
                tbUserNumber.Text = "";
                points = 0;
                tbUserNumber.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Choose difficulty! ;)");
            }
        }

        private void tbUserNumber_TextChanged(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    userNumber = Convert.ToInt32(tbUserNumber.Text);
                    points++;
                    if (number == userNumber)
                    {
                        pbPoints.Image = GuessTheNumber.Properties.Resources.download;
                        if (points <= 10)
                        {
                            pbPoints.Image = GuessTheNumber.Properties.Resources.thumb_up_to_like_on_facebook_318_37196;
                        }
                        else
                        {
                            pbPoints.Image = GuessTheNumber.Properties.Resources.no_translate_detected_318_37605;
                        }
                        tbUserNumber.Enabled = false;
                    }
                    else if (number > userNumber)
                    {
                        pbPoints.Image = GuessTheNumber.Properties.Resources.download;
                    }
                    else
                    {
                        pbPoints.Image = GuessTheNumber.Properties.Resources.strzałka_w_doł_czarny_318_40178;
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Nice try!");
                }
            }
        }
    
    }
}
