using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hastane.Common
{
  public  class Bolum:Object
    {
        public string BolumunAdi { get; set; }
        public string BolumAciklamasi { get; set; }


        public override string ToString()
        {
            return BolumunAdi + " " + BolumAciklamasi;
        }

        //CANLI nefes alması
        /*
         * bitkiler , hayvanlar kalbi atar,
                        omurgalı 
                        insan  yürüme          
         */
    }
}
