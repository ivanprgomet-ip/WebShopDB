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

        [Required(ErrorMessage ="Manufacturer/Brand name Required")]
        public string ManufacturerName { get; set; }
    }
}