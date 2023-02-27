using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Common
{
 public   class Hasta
    {

        public string AdSoyad { get; set; }
        public Doktor Doktor { get; set; }
        public string RandevuTarihi { get; set; }
    }
}
