using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class Marka
    {
        public int MarkaId {  get; set; }
        public string MarkaAd { get; set; }
        public bool IsDeleted { get; set; }
        public List<Model> Models { get; set; }
    }
}
