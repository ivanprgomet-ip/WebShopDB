using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Manufacturer
    {
        public int ManufacturerID { get; set; }
        [Required]
        [MaxLength(250)]
        public string ManufacturerName { get; set; }
    }
}