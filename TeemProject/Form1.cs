using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeemProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double height, weight, bmi, coef;
        int age, caloriesNorm;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (!double.TryParse(txtBoxHeight.Text, out height))//Check, whether entered height is double
            {
                MessageBox.Show("Height should be a positive number of double type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxHeight.Clear();
                return;
            }
            if (!double.TryParse(txtBoxWeight.Text, out weight))//Check, whether entered weight is double
            {
                MessageBox.Show("Weight should be a positive number of double type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxWeight.Clear();
                return;
            }
            if (!int.TryParse(txtBoxAge.Text, out age))//Check, whether entered age is int
            {
                MessageBox.Show("Age should be a positive number of integer type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAge.Clear();
                return;
            }
 
            if (height <= 0)// Check, whether entered height is positive
            {
                MessageBox.Show("Height should be a positive number of double type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxHeight.Clear();
                return;
            }

            if (weight <= 0)// Check, whether entered weight is positive
            {
                MessageBox.Show("Weight should be a positive number of double type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxWeight.Clear();
                return;
            }

            if (age <= 0)// Check, whether entered age is positive
            {
                MessageBox.Show("Age should be a positive number of integer type", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxAge.Clear();
                return;
            }

            // Coefficiencies
            if (radioButton1.Checked)
            {
                coef = 1.2;
            }
            else
            {
                if (radioButton2.Checked)
                {
                    coef = 1.375;
                }
                else
                {
                     if (radioButton3.Checked)
                     {
                         coef = 1.4625;
                     }
                     else
                     {
                         if (radioButton4.Checked)
                         {
                             coef = 1.55;
                         }
                         else
                         {
                             if (radioButton5.Checked)
                             {
                                 coef = 1.6375;
                             }
                             else
                             {
                                 if (radioButton6.Checked)
                                 {
                                     coef = 1.725;
                                 }
                                 else
                                 {
                                     if (radioButton7.Checked)
                                     {
                                         coef = 1.9;
                                     }
                                     else
                                     {
                                         MessageBox.Show("Please, choose your level of physical activity");
                                     }
                                 }
                             }
                         }
                     }                       
                }
            }

            if (comboBoxGender.SelectedIndex == 0)// If mail
            {
                caloriesNorm = (int)(Math.Round(coef * (10 * weight + 6.25 * height - 5 * age + 5)));
            }
            else
            {
               if (comboBoxGender.SelectedIndex == 1)// if femail
               {
                    caloriesNorm = (int)(Math.Round(coef * (10 * weight + 6.25 * height - 5 * age - 161)));
               }
               else
               {
                  MessageBox.Show("Please, choose your gender!");// if not chosen
               }                   
            }
            
                       
            bmi = (weight*10000) / (height*height);
            bmi = Math.Round(bmi, 2);
            string bmiString = "Your BMI equals " + bmi + ".";
            listBox1.Items.Add(bmiString);
            string infoString;
            if (bmi < 18.5)
            {
                infoString = "You have an underweight.";
            }
            else
            {
                if (bmi <= 25)
                {
                    infoString = "You have a normal weight.";
                }
                else
                {
                    infoString = "You have an overweight.";
                    caloriesNorm = (int)(Math.Round(0.8 * caloriesNorm));
                }
            }

            listBox1.Items.Add(infoString);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f = new Form2(caloriesNorm);
            f.ShowDialog();
            Close();
        }
        
    }
}
