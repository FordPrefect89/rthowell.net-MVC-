﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class PrimerManufacturers
    {
        [Key]
        public int PrimerId { get; set; }

        public string MfgName { get; set; }
        public string Type { get; set; }
    }
}