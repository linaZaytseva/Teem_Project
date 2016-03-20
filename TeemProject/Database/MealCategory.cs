using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemProject
{
    public class MealCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MealCategory(string Name)
        {
            this.Name = Name;
        }
    }
}
