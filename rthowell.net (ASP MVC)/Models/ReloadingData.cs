using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace rthowell.net__ASP_MVC_.Models
{
    public class ReloadingData
    {
        public int Id { get; set; }
        public string Cartridge { get; set; }
        //[DisplayFormat(DataFormatString="{0:MM/dd/yyyy")]
        public DateTime DateLoaded { get; set; }
        public string LoadSource { get; set; }
        public string BulletBrand { get; set; }
        public string BulletType { get; set; }
        public int BulletWeight { get; set; }
        public string Powder { get; set; }
        public double PowderWeight { get; set; }
        public string PowderLot { get; set; }
        public string PrimerBrand { get; set; }
        public string PrimerType { get; set; }
        public string PrimerLot { get; set; }
        public string COL { get; set; }
        public double Speed { get; set; }
        public string Notes { get; set; }
    }
}