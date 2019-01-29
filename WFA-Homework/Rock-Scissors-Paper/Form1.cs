using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Scissors_Paper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int randomGenerator;
        string userChoice;
        string computerChoice;
        int userScore = 0;
        int computerScore = 0;
        Random rnd = new Random();

        private void pbRock_Click_1(object sender, EventArgs e)
        {

            userChoice = "Rock";
            pbUser.Image = Rock_Scissors_Paper.Properties.Resources.download;
            Computer();

        }

        private void pbScissors_Click_1(object sender, EventArgs e)
        {
            userChoice = "Scissors";
            pbUser.Image = Rock_Scissors_Paper.Properties.Resources._004224_1;
            Computer();

        }
        private void pbPaper_Click_1(object sender, EventArgs e)
        {

            userChoice = "Paper";
            pbUser.Image = Rock_Scissors_Paper.Properties.Resources._61XMr2MDNtL__SY355_;
            Computer();

        }
        
        private void Computer()
        {
            randomGenerator = rnd.Next(1, 4);
            if (randomGenerator == 1)
            {
                computerChoice = "Rock";
                pbComputer.Image = Rock_Scissors_Paper.Properties.Resources.download;
                
            }
            else if (randomGenerator == 2)
            {
                computerChoice = "Paper";
                pbComputer.Image = Rock_Scissors_Paper.Properties.Resources._61XMr2MDNtL__SY355_;
                
            }
            else if (randomGenerator == 3)
            {
                computerChoice = "Scissors";
                pbComputer.Image = Rock_Scissors_Paper.Properties.Resources._004224_1;
                
            }
            if ((userChoice == "Rock" && computerChoice == "Scissors") || (userChoice == "Paper" & computerChoice == "Rock") || (userChoice == "Scissors" & computerChoice == "Paper"))
            {
                userScore++;
                lblUser.Text =  userScore + " : " + computerScore;
               
                MessageBox.Show("You Won the round!");
            }
            else if (userChoice == computerChoice)
            {
                MessageBox.Show("TIE!");
            }
            else
            {
                computerScore++;
                lblUser.Text = userScore + " : " + computerScore;
                MessageBox.Show("Computer Won!");
            }
        }
            private void btnReset_Click_1(object sender, EventArgs e)
        {
            pbComputer.BackgroundImage = pbUser.BackgroundImage;

            pbUser.BackgroundImage = pbComputer.BackgroundImage;
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Jokes on you! You can play without that button nibba!");
        }
    }

}
    

