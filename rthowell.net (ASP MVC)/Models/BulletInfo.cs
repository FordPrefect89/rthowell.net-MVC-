using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class BulletInfo
    {
        [Key]
        public int BulletId { get; set; }

        public string Mfg { get; set; }
        public string Type { get; set; }
        public string Caliber { get; set; }
        public int Weight { get; set; }
    }
}