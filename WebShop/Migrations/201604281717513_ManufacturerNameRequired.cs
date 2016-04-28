namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManufacturerNameRequired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Manufacturers", "ManufacturerName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Manufacturers", "ManufacturerName", c => c.String());
        }
    }
}
