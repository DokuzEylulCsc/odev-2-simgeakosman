using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteBilgiSistemi
{
    abstract class Ogrenci
    {
       
        private string AdiSoyadi { get; set; }

        private string Ogr_no;

       public string OgrNo
        {
            get { return Ogr_no; }
            set
            {
                if (!value.StartsWith("0"))
                {
                    Ogr_no = value;
                }

            }
        }
        public Ogrenci (string AdiSoyadi,string Ogr_no)
        {
            this.AdiSoyadi = AdiSoyadi;
            this.Ogr_no = Ogr_no;
        }


       
    }
}
