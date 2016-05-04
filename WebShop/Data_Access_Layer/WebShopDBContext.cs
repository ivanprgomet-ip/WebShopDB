using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebShop.Models;

namespace WebShop.Data_Access_Layer
{
    public class WebShopDBContext:DbContext
    {
        public WebShopDBContext()
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CorporateCustomer> CorporateCustomers { get; set; }
        public DbSet<PrivateCustomer> PrivateCustomers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<ShippingCompany> ShippingCompanies { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Audit> Audits { get; set; }

        public DbSet<ProductOrder> ProductOrders { get; set; }//temp
    }
}