using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class yakitTuru
    {
        [Key]
        public int yakitTuruID { get; set; }
        [MaxLength(100)]
        public string Tur { get; set; }
        public List<IsEmri> IsEmris { get; set; }
    }
}
