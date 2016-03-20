using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemProject.Migrations
{
    class DishRecord
    {
        public string Name { get; set; }
        public int KKal { get; set; }
        public double Protein { get; set; }
        public double Fat { get; set; }
        public double Carbohydrates { get; set; }
        public string EatingTime { get; set; }
    }
}
