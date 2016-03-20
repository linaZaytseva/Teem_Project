namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class s : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "EatingTimeId", c => c.Int(nullable: false));
            AddColumn("dbo.Dishes", "MealCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dishes", "EatingTimeId");
            CreateIndex("dbo.Dishes", "MealCategoryId");
            AddForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories", "Id", cascadeDelete: true);
            DropColumn("dbo.Dishes", "EatingTime");
            DropColumn("dbo.Dishes", "MealCategory");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "MealCategory", c => c.String());
            AddColumn("dbo.Dishes", "EatingTime", c => c.String());
            DropForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories");
            DropForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes");
            DropIndex("dbo.Dishes", new[] { "MealCategoryId" });
            DropIndex("dbo.Dishes", new[] { "EatingTimeId" });
            DropColumn("dbo.Dishes", "MealCategoryId");
            DropColumn("dbo.Dishes", "EatingTimeId");
        }
    }
}
