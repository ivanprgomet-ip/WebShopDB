namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerID = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        Lastname = c.String(),
                        MailAdress = c.String(),
                        StreetAdress = c.String(),
                        City = c.String(),
                        ZipCode = c.String(),
                        CompanyName = c.String(),
                        CompanyPhoneNumber = c.String(),
                        CompanyWebSite = c.String(),
                        MobileNumber = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CustomerID);
            
            CreateTable(
                "dbo.Manufacturers",
                c => new
                    {
                        ManufacturerID = c.Int(nullable: false, identity: true),
                        ManufacturerName = c.String(),
                    })
                .PrimaryKey(t => t.ManufacturerID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        OrderStatus = c.String(),
                        ShippingDate = c.DateTime(nullable: false),
                        TotalPrice = c.Long(nullable: false),
                        CustomerID = c.Int(nullable: false),
                        ShippingCompanyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID)
                .ForeignKey("dbo.Customers", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.ShippingCompanies", t => t.ShippingCompanyID, cascadeDelete: true)
                .Index(t => t.CustomerID)
                .Index(t => t.ShippingCompanyID);
            
            CreateTable(
                "dbo.ProductOrders",
                c => new
                    {
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        ProductQuantity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.OrderID, t.ProductID })
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        DiscountPercentage = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Stock = c.Int(nullable: false),
                        UnitPrice = c.Int(nullable: false),
                        ProductName = c.String(),
                        CategoryID = c.Int(nullable: false),
                        ManufacturerID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Manufacturers", t => t.ManufacturerID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.ManufacturerID);
            
            CreateTable(
                "dbo.ShippingCompanies",
                c => new
                    {
                        ShippingCompanyID = c.Int(nullable: false, identity: true),
                        ShippingCompanyName = c.String(),
                        ShippingCost = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.ShippingCompanyID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Orders", "ShippingCompanyID", "dbo.ShippingCompanies");
            DropForeignKey("dbo.ProductOrders", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Products", "ManufacturerID", "dbo.Manufacturers");
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.ProductOrders", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Orders", "CustomerID", "dbo.Customers");
            DropIndex("dbo.Products", new[] { "ManufacturerID" });
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropIndex("dbo.ProductOrders", new[] { "ProductID" });
            DropIndex("dbo.ProductOrders", new[] { "OrderID" });
            DropIndex("dbo.Orders", new[] { "ShippingCompanyID" });
            DropIndex("dbo.Orders", new[] { "CustomerID" });
            DropTable("dbo.ShippingCompanies");
            DropTable("dbo.Products");
            DropTable("dbo.ProductOrders");
            DropTable("dbo.Orders");
            DropTable("dbo.Manufacturers");
            DropTable("dbo.Customers");
            DropTable("dbo.Categories");
        }
    }
}
