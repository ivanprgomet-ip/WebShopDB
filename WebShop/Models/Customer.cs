using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public abstract class Customer
    {
        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [Required(ErrorMessage ="Email Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string EmailAdress { get; set; }
        public string StreetAdress { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }


    }
}