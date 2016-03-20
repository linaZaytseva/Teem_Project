namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishChange_4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dishes", "EatingTime_Id", "dbo.EatingTimes");
            DropForeignKey("dbo.Dishes", "MealCategory_Id", "dbo.MealCategories");
            DropIndex("dbo.Dishes", new[] { "EatingTime_Id" });
            DropIndex("dbo.Dishes", new[] { "MealCategory_Id" });
            RenameColumn(table: "dbo.Dishes", name: "EatingTime_Id", newName: "EatingTimeId");
            RenameColumn(table: "dbo.Dishes", name: "MealCategory_Id", newName: "MealCategoryId");
            AlterColumn("dbo.Dishes", "EatingTimeId", c => c.Int(nullable: false));
            AlterColumn("dbo.Dishes", "MealCategoryId", c => c.Int(nullable: false));
            CreateIndex("dbo.Dishes", "EatingTimeId");
            CreateIndex("dbo.Dishes", "MealCategoryId");
            AddForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories");
            DropForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes");
            DropIndex("dbo.Dishes", new[] { "MealCategoryId" });
            DropIndex("dbo.Dishes", new[] { "EatingTimeId" });
            AlterColumn("dbo.Dishes", "MealCategoryId", c => c.Int());
            AlterColumn("dbo.Dishes", "EatingTimeId", c => c.Int());
            RenameColumn(table: "dbo.Dishes", name: "MealCategoryId", newName: "MealCategory_Id");
            RenameColumn(table: "dbo.Dishes", name: "EatingTimeId", newName: "EatingTime_Id");
            CreateIndex("dbo.Dishes", "MealCategory_Id");
            CreateIndex("dbo.Dishes", "EatingTime_Id");
            AddForeignKey("dbo.Dishes", "MealCategory_Id", "dbo.MealCategories", "Id");
            AddForeignKey("dbo.Dishes", "EatingTime_Id", "dbo.EatingTimes", "Id");
        }
    }
}
