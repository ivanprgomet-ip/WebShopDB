using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public decimal DiscountPercentage { get; set; }
        public int Stock { get; set; }
        public int UnitPrice { get; set; }
        public string ProductName { get; set; }

        public int CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category Category { get; set; }

        public int ManufacturerID { get; set; }
        [ForeignKey("ManufacturerID")]
        public virtual Manufacturer Manufacturer { get; set; }

        public virtual ICollection<ProductOrder> Orders { get; set; }
    }
}