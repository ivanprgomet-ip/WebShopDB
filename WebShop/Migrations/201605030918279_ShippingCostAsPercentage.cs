namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ShippingCostAsPercentage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ShippingCompanies", "ShippingCostPercentage", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.ShippingCompanies", "ShippingCost");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ShippingCompanies", "ShippingCost", c => c.Long(nullable: false));
            DropColumn("dbo.ShippingCompanies", "ShippingCostPercentage");
        }
    }
}
