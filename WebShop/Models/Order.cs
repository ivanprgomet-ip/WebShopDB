using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebShop.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public string OrderStatus { get; set; }
        public long TotalPrice { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]//makes it pretty on website
        [Required(ErrorMessage ="ShippingDate is Required")]
        public DateTime ShippingDate { get; set; }

        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Customer { get; set; }
        
        public int? ShippingCompanyID { get; set; }
        [ForeignKey("ShippingCompanyID")]
        public virtual ShippingCompany ShippingCompany { get; set; }
        
        public virtual ICollection<ProductOrder> ProductOrders { get; set; }
    }
}