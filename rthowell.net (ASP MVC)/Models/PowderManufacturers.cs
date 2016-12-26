using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class PowderManufacturers
    {
        [Key]
        public int PowderId { get; set; }

        public string PowderMfg { get; set; }
        public string PowderName { get; set; }
    }
}