namespace TeemProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class A : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Dishes", "Carbohydrate", c => c.Double(nullable: false));
            DropColumn("dbo.Dishes", "Er");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Dishes", "Er", c => c.Int(nullable: false));
            DropColumn("dbo.Dishes", "Carbohydrate");
        }
    }
}
