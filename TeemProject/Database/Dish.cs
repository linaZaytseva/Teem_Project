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
        public List<EatingTime> EatingTimes { get; set; }
    }
}
