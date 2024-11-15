using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class bakimGrubu
    {

        public int bakimGrubuID { get; set; }
        public string bakimGrubuAdi { get; set; }
        public bool IsDeleted { get; set; }
        public List<bakimTuru> bakimTurus { get; set; }
    }
}
