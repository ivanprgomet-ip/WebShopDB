using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class ShippingCompany
    {
        public int ShippingCompanyID { get; set; }
        [Required(ErrorMessage ="Name of Shippingcompany is Required")]
        public string ShippingCompanyName { get; set; }
        [Required(ErrorMessage = "The Shipping Cost Percentage is Required")]
        public decimal ShippingCostPercentage { get; set; }

    }
}