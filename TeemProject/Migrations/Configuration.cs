namespace TeemProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    internal sealed class Configuration : DbMigrationsConfiguration<TeemProject.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        private List<DishRecord> LoadDishesFromCSV(string filename)
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream(filename))
            {
                var dishes = new List<DishRecord>();
                using (var sr = new StreamReader(stream))
                {
                    // Skip headers
                    sr.ReadLine();
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var items = line.Split(';');
                        dishes.Add(new DishRecord
                        {
                            Name = items[0],
                            KKal = int.Parse(items[1]),
                            Protein = double.Parse(items[2]),
                            Fat = double.Parse(items[3]),
                            Carbohydrates = double.Parse(items[4]),
                            EatingTime = items[5],
                        });
                    }
                }
                return dishes;
            }
        }
        protected override void Seed(TeemProject.Context context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            var data = LoadDishesFromCSV("TeamProject.DataProject.csv");
            foreach (var item in data)
            {
                foreach (var eatingTime in item.EatingTime)
                {
                    var eat = new EatingTime { Name = eatingTime.ToString() };
                    context.EatingTime.AddOrUpdate(c => c.Name, eat);
                }

                context.SaveChanges();
                var dish = new Dish
                {
                    Name = item.Name,
                    KKal = item.KKal,
                    Protein = item.Protein,
                    Fat = item.Fat,
                    Carbohydrate = item.Carbohydrates,
                    EatingTimes = context.EatingTime.Where(c => item.EatingTime.Contains(c.Name)).ToList()
                };
                context.Dish.AddOrUpdate(d => new { d.Name, d.KKal, d.Protein, d.Fat, d.Carbohydrate}, dish);
                context.SaveChanges();
            }
        }
    }

}

