using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    [Table("tblAudit")]
    public class Audit
    {
        [Key]
        public int LogID { get; set; }
        public string LogMsg { get; set; }
    }
}