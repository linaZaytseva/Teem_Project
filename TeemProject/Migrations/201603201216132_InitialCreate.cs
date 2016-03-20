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
                        KKal = c.Int(nullable: false),
                        Protein = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Carbohydrate = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EatingTimes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EatingTimeDishes",
                c => new
                    {
                        EatingTime_Id = c.Int(nullable: false),
                        Dish_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.EatingTime_Id, t.Dish_Id })
                .ForeignKey("dbo.EatingTimes", t => t.EatingTime_Id, cascadeDelete: true)
                .ForeignKey("dbo.Dishes", t => t.Dish_Id, cascadeDelete: true)
                .Index(t => t.EatingTime_Id)
                .Index(t => t.Dish_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EatingTimeDishes", "Dish_Id", "dbo.Dishes");
            DropForeignKey("dbo.EatingTimeDishes", "EatingTime_Id", "dbo.EatingTimes");
            DropIndex("dbo.EatingTimeDishes", new[] { "Dish_Id" });
            DropIndex("dbo.EatingTimeDishes", new[] { "EatingTime_Id" });
            DropTable("dbo.EatingTimeDishes");
            DropTable("dbo.EatingTimes");
            DropTable("dbo.Dishes");
        }
    }
}
