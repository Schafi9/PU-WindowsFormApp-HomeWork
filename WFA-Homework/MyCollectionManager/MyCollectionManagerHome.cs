using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCollectionManager
{
    public partial class MyCollectionManagerHome : Form
    {
       
        List<string> catNames = new List<string>();
        List<int> numbers = new List<int>();
        public MyCollectionManagerHome()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string input = tbCatName.Text;
            catNames.Add(input);
            tbCatName.Clear();
            tbCatName.Focus();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < catNames.Count; i++)
            {
                sb.AppendLine($"{i} => {catNames[i]}");
                lbCats.Items.Add(catNames[i]);
            }
            MessageBox.Show(sb.ToString());
           
        }

        private void tbCatName_TextChanged(object sender, KeyPressEventArgs e)
        {
           if(e.KeyChar==(char)Keys.Enter)
            {
                //btnAdd.PerformClick();
                btnAdd_Click(sender, e);
            }
        }

        private void lbCats_SelectedIndexChanged(object sender, EventArgs e)
        {
           // if(lbCats.SelectedItem!=null)
             //   tbCatName.Text = lbCats.SelectedItem.ToString();
        }

        private void bu(object sender, EventArgs e)
        {
            if (lbCats.SelectedItem != null)
                tbCatName.Text = lbCats.SelectedItem.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string updated = tbCatName.Text;
            int currentIndex = lbCats.SelectedIndex;

            lbCats.Items[currentIndex] = updated;

            //lbCats.Items.RemoveAt(currentIndex);
            //catNames.RemoveAt(currentIndex);

            //lbCats.Items.Insert(currentIndex, updated);
            //catNames.Insert(currentIndex, updated);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int currentIndex = lbCats.SelectedIndex;
            lbCats.Items.RemoveAt(currentIndex);
            catNames.RemoveAt(currentIndex);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            string choice = comboBox1.SelectedItem.ToString();

            int iterations = int.Parse(choice);
            for (int i = 0; i < iterations; i++)
            {
                int randomNum = rnd.Next(0, 201);
                lbCats.Items.Add(randomNum);
                numbers.Add(randomNum);
            }
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sum: "+numbers.Sum());
            MessageBox.Show("MIN: " + numbers.Min());
            MessageBox.Show("MAX: " + numbers.Max());
            MessageBox.Show("AVG: " + numbers.Average());
        }

        private void btnTop_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lbCats.SelectedIndex; i--)
            {
                if (lbCats.SelectedItem == null || lbCats.SelectedIndex < 0)
                    return; // No selected item - nothing to do

                // Calculate new index using move direction
                //else
                //{

                    int newIndex = lbCats.SelectedIndex -1;

                    // Checking bounds of the range
                    if (newIndex < 0 || newIndex >= lbCats.Items.Count)
                        return; // Index out of range - nothing to do

                    object selected = lbCats.SelectedItem;

                    // Removing removable element
                    lbCats.Items.Remove(selected);
                    // Insert it in new position
                    lbCats.Items.Insert(newIndex, selected);
                    // Restore selection
                    lbCats.SetSelected(newIndex, true);
                //}
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {     
                MoveItem(-1);    
        }

        public void MoveItem(int direction)
        {
            // Checking selected item
            if (lbCats.SelectedItem == null || lbCats.SelectedIndex < 0)
                return; // No selected item - nothing to do

            // Calculate new index using move direction
            int newIndex =lbCats.SelectedIndex + direction;

            // Checking bounds of the range
            if (newIndex < 0 || newIndex >= lbCats.Items.Count)
                return; // Index out of range - nothing to do

            object selected = lbCats.SelectedItem;

            // Removing removable element
            lbCats.Items.Remove(selected);
            // Insert it in new position
            lbCats.Items.Insert(newIndex, selected);
            // Restore selection
            lbCats.SetSelected(newIndex, true);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveItem(1);
        }


        private void btnBottom_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= lbCats.SelectedIndex; i++)
            {
                MoveItem(1);
            }
            
        }
    }
}
