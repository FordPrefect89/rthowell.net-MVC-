using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class BulletSpeed
    {
        [Key]
        public int SpeedID { get; set; }
        public float BulletFPS { get; set; }
    }
}