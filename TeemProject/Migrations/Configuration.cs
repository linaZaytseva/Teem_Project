namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeemProject.Context>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
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
            context.MealCategory.AddOrUpdate(
                    p=>p.Name,
                    new MealCategory { Name = "Beverage"},
                    new MealCategory { Name = "Poridge" },
                    new MealCategory { Name = "Toast" },
                    new MealCategory { Name = "First course" },
                    new MealCategory { Name = "Second course" },
                    new MealCategory { Name = "Fruit" },
                    new MealCategory { Name = "Vegetables" },
                    new MealCategory { Name = "Salad" }
                );
            context.EatingTime.AddOrUpdate(
                    p=>p.Name,
                    new EatingTime { Name = "Breakfast"},
                    new EatingTime { Name = "Lunch" },
                    new EatingTime { Name = "Dinner" },
                    new EatingTime { Name = "Afternoon snack" },
                    new EatingTime { Name = "Supper" }
                );
            context.Dish.AddOrUpdate(
                    
                );
        }
    }
}
