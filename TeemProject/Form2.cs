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
    public partial class Form2 : Form
    {
        public Form2(int data, List<Dish> list)
        {
            InitializeComponent();
            caloriesNorm = data;
            Dishes = list;
        }

        List<Dish> Dishes = new List<Dish>();
        int caloriesNorm;
        List<String> typeList = new List<string>();

        // Method for avaliable meal generation
        List<Dish> MakeList(List<String> list)
        {
            List<Dish> avaliableDishes = new List<Dish>();
            foreach (Dish item in Dishes)
            {
                if (list.IndexOf(item.MealCategories.Name) >= 0)
                {
                    avaliableDishes.Add(item);
                }
            }
            return avaliableDishes;
        }

        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            typeList.Clear();
            typeList.Add("Beverage");
            typeList.Add("Poridge&Breakfast");
            typeList.Add("Fruit");
            Form3 f = new Form3(MakeList(typeList));
            f.ShowDialog();
        }

        private void btnLunch_Click(object sender, EventArgs e)
        {
            typeList.Clear();
            typeList.Add("Beverage");
            typeList.Add("Toast");
            typeList.Add("Fruit");
            Form3 f = new Form3(MakeList(typeList));
            f.ShowDialog();
        }
    }
}
