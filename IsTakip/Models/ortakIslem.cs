using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class ortakIslem
    {
        public int ortakIslemID { get; set; }
        public int ID { get; set; }
        public string IslemAdi { get; set; }
        public int Adet { get; set; }
        public decimal birimFiyat { get; set; }
        public decimal toplamFiyat { get; set; }
        public DateTime IslemTarihi { get; set; }
        public bool digerIslem { get; set; }
    }
}
