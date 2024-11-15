using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class IsEmri
    {
        public int IsEmriID { get; set; }
        public int ModelId { get; set; } // Sadece Model Çekmek Yeterli 
        public string Plaka { get; set; }
        public string SasiNo { get; set; }
        public int Km { get; set; }
        public int ModelYili { get; set; }
        public int YakitTuruID { get; set; }
        public DateTime GelisTarihi { get; set; }
        public string GelisSebebi { get; set; }
        public int MusteriId { get; set; }
        public bool IsDeleted { get; set; }
        public bool Kapali {  get; set; }
        public  DateTime? kapatmaTarihi { get; set; }
        public decimal? alinanUcret { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual Model Model { get; set; }
        public virtual yakitTuru YakitTuru { get; set; }
        public List<Islemler> Islemlers { get; set; } 
        public List<IsDiger> IsDigers { get; set; }
    }
}
