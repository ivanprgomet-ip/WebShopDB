using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class ShippingCompany
    {
        public int ShippingCompanyID { get; set; }
        public string ShippingCompanyName { get; set; }
        public decimal ShippingCostPercentage { get; set; }

    }
}