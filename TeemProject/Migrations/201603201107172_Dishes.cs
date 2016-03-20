namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Dishes : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes");
            DropForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories");
            DropIndex("dbo.Dishes", new[] { "EatingTimeId" });
            DropIndex("dbo.Dishes", new[] { "MealCategoryId" });
            AddColumn("dbo.Dishes", "EatingTime", c => c.String());
            AddColumn("dbo.Dishes", "MealCategory", c => c.String());
            DropColumn("dbo.Dishes", "EatingTimeId");
            DropColumn("dbo.Dishes", "MealCategoryId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "MealCategoryId", c => c.Int(nullable: false));
            AddColumn("dbo.Dishes", "EatingTimeId", c => c.Int(nullable: false));
            DropColumn("dbo.Dishes", "MealCategory");
            DropColumn("dbo.Dishes", "EatingTime");
            CreateIndex("dbo.Dishes", "MealCategoryId");
            CreateIndex("dbo.Dishes", "EatingTimeId");
            AddForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes", "Id", cascadeDelete: true);
        }
    }
}
