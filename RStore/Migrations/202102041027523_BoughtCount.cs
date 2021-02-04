namespace RStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BoughtCount : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "BoughtCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "BoughtCount");
        }
    }
}
