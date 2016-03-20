namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishChange_3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes");
            DropForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories");
            DropIndex("dbo.Dishes", new[] { "EatingTimeId" });
            DropIndex("dbo.Dishes", new[] { "MealCategoryId" });
            RenameColumn(table: "dbo.Dishes", name: "EatingTimeId", newName: "EatingTime_Id");
            RenameColumn(table: "dbo.Dishes", name: "MealCategoryId", newName: "MealCategory_Id");
            AlterColumn("dbo.Dishes", "EatingTime_Id", c => c.Int());
            AlterColumn("dbo.Dishes", "MealCategory_Id", c => c.Int());
            CreateIndex("dbo.Dishes", "EatingTime_Id");
            CreateIndex("dbo.Dishes", "MealCategory_Id");
            AddForeignKey("dbo.Dishes", "EatingTime_Id", "dbo.EatingTimes", "Id");
            AddForeignKey("dbo.Dishes", "MealCategory_Id", "dbo.MealCategories", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "MealCategory_Id", "dbo.MealCategories");
            DropForeignKey("dbo.Dishes", "EatingTime_Id", "dbo.EatingTimes");
            DropIndex("dbo.Dishes", new[] { "MealCategory_Id" });
            DropIndex("dbo.Dishes", new[] { "EatingTime_Id" });
            AlterColumn("dbo.Dishes", "MealCategory_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Dishes", "EatingTime_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Dishes", name: "MealCategory_Id", newName: "MealCategoryId");
            RenameColumn(table: "dbo.Dishes", name: "EatingTime_Id", newName: "EatingTimeId");
            CreateIndex("dbo.Dishes", "MealCategoryId");
            CreateIndex("dbo.Dishes", "EatingTimeId");
            AddForeignKey("dbo.Dishes", "MealCategoryId", "dbo.MealCategories", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Dishes", "EatingTimeId", "dbo.EatingTimes", "Id", cascadeDelete: true);
        }
    }
}
