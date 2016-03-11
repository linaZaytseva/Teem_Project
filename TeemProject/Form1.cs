﻿using System;
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

        double height, weight, bmi;
        int code;

        private void button1_Click(object sender, EventArgs e)
        {
            height = double.Parse(txtBoxHeight.Text);// add exeption
            weight = double.Parse(txtBoxWeight.Text);// add exeption
            //double.TryParse(txtBoxHeight.Text, out height);
            bmi = weight / (height*height);
            bmi = Math.Round(bmi, 2);
            string bmiString = "Your BMI equals" + bmi + ".";
            listBox1.Items.Add(bmiString);
            string infoString;
            if (bmi < 18.5)
            {
                infoString = "You have an underweight.";
                code = -1;
            }
            else
            {
                if (bmi <= 25)
                {
                    infoString = "You have a normal weight.";
                    code = 0;
                }
                else
                {
                    infoString = "You have an overweight.";
                    code = 1;
                }
            }

            listBox1.Items.Add(infoString);
        }
        
    }
}