namespace WebShop.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebShop.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebShop.Data_Access_Layer.WebShopDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(WebShop.Data_Access_Layer.WebShopDBContext context)
        {

            /*the private and corporate customers are using the AddOrUpdate extension method 
            to avoid creating duplicate seed data. the private customers "uniqueness" is based on 
            their mobile number, and the corporate customers "uniqueness" is based up of their
            company mail adress. We could not have the CustomerID (even though this would have 
            been suitable) because its an identity column and autoincremented, which would 
            have successfully generated duplicate customers every time the database got updated*/

            //private customers
            context.PrivateCustomers.AddOrUpdate(p => p.MobileNumber,
                new PrivateCustomer()
                {
                    Firstname = "Erik",
                    Lastname = "Svensson",
                    City = "Hoganas",
                    MailAdress = "Erik.Svensson@hotmail.com",
                    StreetAdress = "Långgatan 82",
                    ZipCode = "26339",
                    MobileNumber = "0735874526"
                },
                new PrivateCustomer()
                {
                    Firstname = "Cindy",
                    Lastname = "Samson",
                    City = "Greenwich",
                    MailAdress = "CoolCindy74@Gmail.com",
                    StreetAdress = "Long Street 41",
                    ZipCode = "2585",
                    MobileNumber = "0478596652"
                },
                new PrivateCustomer()
                {
                    Firstname = "James",
                    Lastname = "Wellington",
                    City = "Bighton",
                    MailAdress = "James.Wellington@Gmail.com",
                    StreetAdress = "Sixth Street",
                    ZipCode = "4712",
                    MobileNumber = "2548464646"
                });

            //corporate customers
            context.CorporateCustomers.AddOrUpdate(c => c.MailAdress,
                new CorporateCustomer()
                {
                    Firstname = "Bobby",
                    Lastname = "Nelson",
                    City = "Luzern",
                    MailAdress = "Bobby@LHotel.ch",
                    StreetAdress = "WeibStrase 7",
                    ZipCode = "8888",
                    CompanyName = "LuzernHotel",
                    CompanyPhoneNumber = "08899899999",
                    CompanyWebSite = "www.LuzernHotel.ch",
                },
               new CorporateCustomer()
               {
                   Firstname = "Lenny",
                   Lastname = "Graves",
                   City = "London",
                   MailAdress = "LennyGraves@Adastra.com",
                   StreetAdress = "High Road 4",
                   ZipCode = "7777",
                   CompanyName = "Adastra Minerals",
                   CompanyPhoneNumber = "9999952589",
                   CompanyWebSite = "www.AdastraMinerals.com",
               },
                new CorporateCustomer()
                {
                    Firstname = "Abraham",
                    Lastname = "Bergemont",
                    City = "New Hampshire",
                    MailAdress = "A.Bergemont@Greycon.com",
                    StreetAdress = "Sixth Avenue",
                    ZipCode = "2585",
                    CompanyName = "Greycon",
                    CompanyPhoneNumber = "369369987987",
                    CompanyWebSite = "www.Greycon.com",
                });

            context.Manufacturers.AddOrUpdate(p => p.ManufacturerName,
                new Manufacturer { ManufacturerName = "Adidas" },
                new Manufacturer { ManufacturerName = "Nike" },
                new Manufacturer { ManufacturerName = "Converse" },
                new Manufacturer { ManufacturerName = "Ralph Lauren" },
                new Manufacturer { ManufacturerName = "Diesel" },
                new Manufacturer { ManufacturerName = "Holister" },
                new Manufacturer { ManufacturerName = "Levis" }
                );

            context.ShippingCompanies.AddOrUpdate(s => s.ShippingCompanyName,
                new ShippingCompany() { ShippingCompanyName = "DHL", ShippingCostPercentage = 0.02M },
                new ShippingCompany() { ShippingCompanyName = "DB Schenker", ShippingCostPercentage = 0.04M },
                new ShippingCompany() { ShippingCompanyName = "Maersk", ShippingCostPercentage = 0.2M }
                );

            context.Categories.AddOrUpdate(c => c.CategoryName,
                new Category() { CategoryName = "Jeans", Description = "hiqh quality jeans in all sizes and shapes!" },
                new Category() { CategoryName = "Jackets", Description = "Jackets in high quality, for both summer and winter conditions!" },
                new Category() { CategoryName = "Shoes", Description = "Shoes ranging from all types of manufacturers!" },
                new Category() { CategoryName = "Shirts", Description = "High quality shirts for hot and spicey summerdays (and nights)!" }
                );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
