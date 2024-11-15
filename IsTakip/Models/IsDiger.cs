using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class IsDiger
    {
        [Key]
        public int IsDigerID { get; set; }
        public int IsEmriID { get; set; }
        public string bakimTuruAdi { get; set; }
        public int Adet { get; set; }
        public decimal birimFiyat { get; set; }
        public decimal toplamFiyat { get; set; }
        public DateTime IslemTarihi { get; set; }
        public virtual IsEmri IsEmri { get; set; }

    }
}
