using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class BrassInfo
    {
        [Key]
        public int BrassId { get; set; }
        [Required]
        public string Caliber { get; set; }

        public string BrassMfg { get; set; }
        public float? BrassWeight { get; set; }
        public int? Quantity { get; set; }
        public float? BrassLength { get; set; }
    }
}