using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class CorporateCustomer:Customer
    {

        [Required(ErrorMessage="Company Name is Required")]
        public string CompanyName { get; set; }
        public string CompanyPhoneNumber { get; set; }

        public string CompanyWebSite { get; set; }

    }
}