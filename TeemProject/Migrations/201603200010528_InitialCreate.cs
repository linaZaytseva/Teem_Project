namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Dishes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        KKal = c.Int(nullable: true),
                        Protein = c.Double(nullable: true),
                        Fat = c.Double(nullable: true),
                        Carbohydrate = c.Double(nullable: true),
                        EatingTime_Id = c.Int(),
                        MealCategory_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.EatingTimes", t => t.EatingTime_Id)
                .ForeignKey("dbo.MealCategories", t => t.MealCategory_Id)
                .Index(t => t.EatingTime_Id)
                .Index(t => t.MealCategory_Id);
            
            CreateTable(
                "dbo.EatingTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.MealCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Dishes", "MealCategory_Id", "dbo.MealCategories");
            DropForeignKey("dbo.Dishes", "EatingTime_Id", "dbo.EatingTimes");
            DropIndex("dbo.Dishes", new[] { "MealCategory_Id" });
            DropIndex("dbo.Dishes", new[] { "EatingTime_Id" });
            DropTable("dbo.MealCategories");
            DropTable("dbo.EatingTimes");
            DropTable("dbo.Dishes");
        }
    }
}
