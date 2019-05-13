using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteBilgiSistemi
{
     public class Ders
    {
        public String ders_adi{ get; set; }
        public string ders_ID { get; set; }
        public Ders(string ders_adi,string ders_ID)
        {
            this.ders_adi = ders_adi;
            this.ders_ID = ders_ID;
        }


    }
}
