using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Common
{
  public  class Doktor
    {
        public string AdSoyad { get; set; }
        public string MezunUni { get; set; }
        public string Cep { get; set; }
        public string Mail { get; set; }
        public Bolum DoktorunBolumu { get; set; }


        public override string ToString()
        {
            return AdSoyad + " " + DoktorunBolumu.BolumunAdi;
        }

    }
}
