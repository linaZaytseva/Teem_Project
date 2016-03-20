namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DishChange : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Dishes", new[] { "EatingTime_Id1" });
            DropIndex("dbo.Dishes", new[] { "MealCategory_Id1" });
            DropColumn("dbo.Dishes", "EatingTime_Id");
            DropColumn("dbo.Dishes", "MealCategory_Id");
            RenameColumn(table: "dbo.Dishes", name: "EatingTime_Id1", newName: "EatingTime_Id");
            RenameColumn(table: "dbo.Dishes", name: "MealCategory_Id1", newName: "MealCategory_Id");
            AlterColumn("dbo.Dishes", "EatingTime_Id", c => c.Int());
            AlterColumn("dbo.Dishes", "MealCategory_Id", c => c.Int());
            CreateIndex("dbo.Dishes", "EatingTime_Id");
            CreateIndex("dbo.Dishes", "MealCategory_Id");
        }
        
        public override void Down()
        {
            DropIndex("dbo.Dishes", new[] { "MealCategory_Id" });
            DropIndex("dbo.Dishes", new[] { "EatingTime_Id" });
            AlterColumn("dbo.Dishes", "MealCategory_Id", c => c.Int(nullable: false));
            AlterColumn("dbo.Dishes", "EatingTime_Id", c => c.Int(nullable: false));
            RenameColumn(table: "dbo.Dishes", name: "MealCategory_Id", newName: "MealCategory_Id1");
            RenameColumn(table: "dbo.Dishes", name: "EatingTime_Id", newName: "EatingTime_Id1");
            AddColumn("dbo.Dishes", "MealCategory_Id", c => c.Int(nullable: false));
            AddColumn("dbo.Dishes", "EatingTime_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.Dishes", "MealCategory_Id1");
            CreateIndex("dbo.Dishes", "EatingTime_Id1");
        }
    }
}
