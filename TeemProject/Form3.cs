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
        public Form3(List<Dish> list)
        {
            InitializeComponent();
            avaliableDishes = list;
        }

        List<Dish> avaliableDishes = new List<Dish>();
        private void Form3_Load(object sender, EventArgs e)
        {
            update();
        }

        public void update()
        {
            dGV.ColumnCount = 5;
            dGV.Columns[0].Name = "Dish Name";
            dGV.Columns[1].Name = "Calories";
            dGV.Columns[2].Name = "Protein";
            dGV.Columns[3].Name = "Fat";
            dGV.Columns[4].Name = "Carbohydrate";

            foreach (Dish item in avaliableDishes)
            {
                ArrayList row = new ArrayList();
                row.Add(item.Name);
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
    }
}
