using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class Ledger
    {
        public int Id { get; set; }
        public string Cartridge { get; set; }
        public DateTime DateLoaded { get; set; }
        public string LoadSource { get; set; }
        public string COL { get; set; }
        public double Speed { get; set; }
        public string Notes { get; set; }
    }
}