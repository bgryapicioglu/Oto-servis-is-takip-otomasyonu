using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class Islemler
    {
        public int IslemlerID { get; set; }
        public int IsEmriID { get; set; }
        public int bakimTuruID { get; set; }
        public int Adet { get; set; }
        public decimal birimFiyat { get; set; }
        public decimal toplamFiyat { get; set; }
        public DateTime islemTarihi { get; set; }
        public virtual bakimTuru bakimTuru { get; set; }
        public virtual IsEmri IsEmri { get; set; }
    }
}
