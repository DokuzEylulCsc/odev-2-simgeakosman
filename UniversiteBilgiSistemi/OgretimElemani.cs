using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteBilgiSistemi
{
     public class OgretimElemani
    {
        public string Hoca_Adi_Soyadi { get; set; }
        public string Hoca_ID { get; set; }
        public OgretimElemani(string Hoca_Adi_Soyadi,string Hoca_ID)
        {
            this.Hoca_Adi_Soyadi = Hoca_Adi_Soyadi;
            this.Hoca_ID = Hoca_ID;
        }

    }
}
