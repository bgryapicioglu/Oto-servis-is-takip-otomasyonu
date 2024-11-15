using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class bakimTuru
    {
        public int bakimTuruID { get; set; }
        public int bakimGrubuID {  get; set; }
        public string bakimTuruAdi { get; set; }
        public bool IsDeleted { get; set; }
        public bakimGrubu bakimGrubus {  get; set; }
        public List<Islemler> Islemlers { get; set; }
    }
}
