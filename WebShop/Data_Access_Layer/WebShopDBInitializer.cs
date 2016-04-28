using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebShop.Models;

namespace WebShop.Data_Access_Layer
{
    /*purpose of this class is to populate the webshop with 
    data when the application runs*/
    public class WebShopDBInitializer:DropCreateDatabaseIfModelChanges<WebShopDBContext>
    {
        protected override void Seed(WebShopDBContext context)
        {
            var manufacturer1 = new Manufacturer() { ManufacturerName = "Adidas" };
            var manufacturer2 = new Manufacturer() { ManufacturerName = "Nike" };
            var manufacturer3 = new Manufacturer() { ManufacturerName = "Converse" };
            context.Manufacturers.Add(manufacturer1);
            context.Manufacturers.Add(manufacturer2);
            context.Manufacturers.Add(manufacturer3);

            var shippingCompany1 = new ShippingCompany() { ShippingCompanyName = "DB Schenker", ShippingCost = 199 };
            var shippingCompany2 = new ShippingCompany() { ShippingCompanyName = "DHL", ShippingCost = 249};
            var shippingCompany3 = new ShippingCompany() { ShippingCompanyName = "Maersk", ShippingCost = 399};
            context.ShippingCompanies.Add(shippingCompany1);
            context.ShippingCompanies.Add(shippingCompany2);
            context.ShippingCompanies.Add(shippingCompany3);

            Category category1 = new Category() { CategoryName = "Jeans", Description = "hiqh quality jeans in all sizes and shapes!" };
            Category category2 = new Category() { CategoryName = "Jackets", Description = "Jackets in high quality, for both summer and winter conditions!" };
            Category category3 = new Category() { CategoryName = "Shoes", Description = "Shoes ranging from all types of manufacturers!" };
            Category category4 = new Category() { CategoryName = "Shirts", Description = "Shirts for the summernights and hot days!" };
            Category category5 = new Category() { CategoryName = "Accessories", Description = "Accessories for the ones that like to put some bling in their life!" };
            context.Categories.Add(category1);
            context.Categories.Add(category2);
            context.Categories.Add(category3);
            context.Categories.Add(category4);
            context.Categories.Add(category5);

            Product prod1 = new Product() { ProductName = "Adidas one", DiscountPercentage = 0, Stock = 50, UnitPrice = 499, Manufacturer = manufacturer1,Category= category3 };
            Product prod2 = new Product() { ProductName = "Adidas two", DiscountPercentage = 0, Stock = 50, UnitPrice = 699, Manufacturer = manufacturer1, Category = category3 };
            Product prod3 = new Product() { ProductName = "Nikey one", DiscountPercentage = 0, Stock = 50, UnitPrice = 599, Manufacturer = manufacturer2, Category = category3 };
            Product prod4 = new Product() { ProductName = "Nikey Two", DiscountPercentage = 0, Stock = 50, UnitPrice = 899, Manufacturer = manufacturer2, Category = category3 };
            Product prod5 = new Product() { ProductName = "Converse one", DiscountPercentage = 0, Stock = 50, UnitPrice = 999, Manufacturer = manufacturer3, Category = category3 };
            context.Products.Add(prod1);
            context.Products.Add(prod2);
            context.Products.Add(prod3);
            context.Products.Add(prod4);
            context.Products.Add(prod5);


            /* passing the WebShopDBContext instance 
            into the seed method of the base class */
            base.Seed(context);
        }
    }
}