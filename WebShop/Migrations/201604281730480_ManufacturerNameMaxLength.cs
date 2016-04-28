namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ManufacturerNameMaxLength : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Manufacturers", "ManufacturerName", c => c.String(nullable: false, maxLength: 250));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Manufacturers", "ManufacturerName", c => c.String(nullable: false));
        }
    }
}
