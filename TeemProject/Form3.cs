using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public Form3(List<Dish> list, int data)
        {
            InitializeComponent();
            avaliableDishes = list;
            avaliableCalories = data;
        }

        List<Dish> avaliableDishes = new List<Dish>();
        List<Dish> newAvaliableDishes = new List<Dish>();
        List<Dish> finalDishes = new List<Dish>();
        int sum = 0;
        int avaliableCalories;

        private void Form3_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            dGV.ColumnCount = 6;
            dGV.Columns[0].Name = "Dish Name";
            dGV.Columns[1].Name = "MealCategory";
            dGV.Columns[2].Name = "Calories";
            dGV.Columns[3].Name = "Protein";
            dGV.Columns[4].Name = "Fat";
            dGV.Columns[5].Name = "Carbohydrate";

            foreach (Dish item in avaliableDishes)
            {
                ArrayList row = new ArrayList();
                row.Add(item.Name);
                row.Add(item.MealCategories.Name);
                row.Add(item.KKal);
                row.Add(item.Protein);
                row.Add(item.Fat);
                row.Add(item.Carbohydrate);
                dGV.Rows.Add(row.ToArray());
            }

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Add Dish";
            btn.Name = "button";
            btn.Text = "Add";
            btn.UseColumnTextForButtonValue = true;
            dGV.Columns.Add(btn);

            dGV.ReadOnly = true;
        }

        private void dGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                Dish selectedDish = avaliableDishes[e.RowIndex];
                if (sum + selectedDish.KKal > avaliableCalories)
                {
                    MessageBox.Show("You can't choose this one, because there's too mach calories here", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    finalDishes.Add(selectedDish);
                    avaliableCalories -= selectedDish.KKal;
                    string str = "Avaliable number of calories is " + avaliableCalories.ToString();
                    MessageBox.Show(str);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Dish item in finalDishes)
            {
                MessageBox.Show("Your meals");
                MessageBox.Show(item.Name);
            }
        }
    }
}
