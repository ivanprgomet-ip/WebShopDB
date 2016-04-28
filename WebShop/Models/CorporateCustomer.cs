using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string CompanyWebSite { get; set; }

    }
}