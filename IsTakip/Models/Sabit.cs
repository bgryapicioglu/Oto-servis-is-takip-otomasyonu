using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class Sabit
    {
        public int SabitID { get; set; }
        public int kdv { get; set; }
        public string isYeriAdi { get; set; }
        public string yetkiliAdiSoyadi { get; set; }
        public string telefon { get; set; }
        public string eposta { get; set; }
        public string adres { get; set; }
        public string iban1 { get; set; }
        public string iban2 { get; set; }
        public string kullaniciAdi { get; set; }
        public string kullaniciSifre { get; set; }
        public bool beniHatirla { get; set; }
    }
}
