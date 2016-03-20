using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemProject
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int KKal { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrate { get; set; }
        public EatingTime EatingTimes { get; set; }

        public Dish(string Name, int KKal, double Protein, double Fat, double Carbohydrate, EatingTime EatingTimes)
        {
            this.Name = Name;
            this.KKal = KKal;
            this.Protein = Protein;
            this.Fat = Fat;
            this.Carbohydrate = Carbohydrate;
            this.EatingTimes = EatingTimes;
        }
    }
}
