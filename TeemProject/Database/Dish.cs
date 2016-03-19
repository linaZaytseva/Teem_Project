using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemProject
{
    class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int KKal { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrate { get; set; }
        public double Vitamin_A { get; set; }
        public double Vitamin_B1 { get; set; }
        public double Vitamin_B2 { get; set; }
        public double Vitamin_B5 { get; set; }
        public double Vitamin_B6 { get; set; }
        public double Vitamin_B12 { get; set; }
        public double Vitamin_C { get; set; }
        public double Vitamin_E { get; set; }
        public double Vitamin_PP { get; set; }
        public double Vitamin_P { get; set; }
        public double Ferrum { get; set; }
        public double Calcium { get; set; }
        public double Cobalt { get; set; }
        public double Magni { get; set; }
        public double Marganets { get; set; }
        public double Med { get; set; }
        public double Zink { get; set; }
        public double Phosphor { get; set; }
        public EatingTime EatingTime { get; set; }
        public MealCategory MealCategory { get; set; }
    }
}
