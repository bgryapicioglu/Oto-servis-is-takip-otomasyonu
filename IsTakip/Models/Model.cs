using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsTakip.Models
{
    internal class Model
    {
        public int ModelId { get; set; }
        public int MarkaID { get; set; }
        public string ModelAd { get; set; }
        public bool IsDeleted { get; set; }
        public Marka Marka { get; set; }
        public List<IsEmri> IsEmris { get; set; }
    }
}
