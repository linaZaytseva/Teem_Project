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
                        Vitamin_A = c.Double(nullable: true),
                        Vitamin_B1 = c.Double(nullable: true),
                        Vitamin_B2 = c.Double(nullable: true),
                        Vitamin_B5 = c.Double(nullable: true),
                        Vitamin_B6 = c.Double(nullable: true),
                        Vitamin_B12 = c.Double(nullable: true),
                        Vitamin_C = c.Double(nullable: true),
                        Vitamin_E = c.Double(nullable: true),
                        Vitamin_PP = c.Double(nullable: true),
                        Vitamin_P = c.Double(nullable: true),
                        Ferrum = c.Double(nullable: true),
                        Calcium = c.Double(nullable: true),
                        Cobalt = c.Double(nullable: true),
                        Magni = c.Double(nullable: true),
                        Marganets = c.Double(nullable: true),
                        Med = c.Double(nullable: true),
                        Zink = c.Double(nullable: true),
                        Phosphor = c.Double(nullable: true),
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
