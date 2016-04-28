using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderStatus { get; set; }
        public DateTime ShippingDate { get; set; }
        public long TotalPrice { get; set; }

        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }

        public int ShippingCompanyID { get; set; }
        [ForeignKey("ShippingCompanyID")]
        public virtual ShippingCompany ShippingCompany { get; set; }
        
        public virtual ICollection<ProductOrder> Products { get; set; }//changed from product to productorder
    }
}