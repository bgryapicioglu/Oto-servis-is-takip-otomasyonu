using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class Musteri
    {
        [Key]
        public int MusteriId { get; set; }
        [MaxLength(100)]
        public string Adi { get; set; }
        [MaxLength(100)]
        public string Soyadi { get; set; }
        [MaxLength(100)]
        public string Telefon { get; set; }
        [MaxLength(100)]
        public string Eposta { get; set; }
        [MaxLength(255)]
        public string Adres { get; set; }
        public bool IsDeleted { get; set; }
        public List<IsEmri> IsEmris { get; set; }
    }
}
