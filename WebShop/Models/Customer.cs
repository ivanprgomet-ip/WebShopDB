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
        [Required(ErrorMessage ="Firstname is Required")]
        public string Firstname { get; set; }
        [Required(ErrorMessage ="Lastname is Required")]
        public string Lastname { get; set; }

        [Required(ErrorMessage ="Email Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string MailAdress { get; set; }

        [Required(ErrorMessage="Street Adress is Required")]
        public string StreetAdress { get; set; }

        [Required(ErrorMessage = "City is Required")]
        public string City { get; set; }

        [Required(ErrorMessage ="ZipCode is Required")]
        public string ZipCode { get; set; }


    }
}