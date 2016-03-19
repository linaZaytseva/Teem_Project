using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeemProject
{
    class Context: DbContext
    {
        public DbSet<Dish> Dish { get; set; }
        public DbSet<EatingTime> EatingTime { get; set; }
        public DbSet<MealCategory> MealCategory { get; set; }
    }
}
