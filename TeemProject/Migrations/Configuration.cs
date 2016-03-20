namespace TeemProject.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Globalization;
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
                            Protein = double.Parse(items[2], CultureInfo.InvariantCulture),
                            Fat = double.Parse(items[3], CultureInfo.InvariantCulture),
                            Carbohydrates = double.Parse(items[4], CultureInfo.InvariantCulture),
                            EatingTime = items[5],
                            MealCategory = items[6]
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
                var eTime = new EatingTime
                {
                    Name = item.EatingTime
                };
                context.EatingTime.AddOrUpdate(e => e.Name,
                    eTime);
                context.SaveChanges();

                var mCat = new MealCategory
                {
                    Name = item.MealCategory
                };
                context.MealCategory.AddOrUpdate(m => m.Name, mCat);
                context.SaveChanges();
                var dish = new Dish
                {
                    Name = item.Name,
                    KKal = item.KKal,
                    Protein = item.Protein,
                    Fat = item.Fat,
                    Carbohydrate = item.Carbohydrates,
                    EatingTime = context.EatingTime.Single(e => e.Name == item.EatingTime),
                    MealCategory = context.MealCategory.Single(m => m.Name == item.MealCategory)
                };
                context.Dish.AddOrUpdate(d => new { d.EatingTime, d.MealCategory }, dish);
                context.SaveChanges();
            }
        }
    }
}
