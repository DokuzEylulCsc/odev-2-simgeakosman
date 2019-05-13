using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteBilgiSistemi
{
   public class Bolum
    {
        
        public string bolum_adi { get; set; }
        public string bolum_ID { get; set; }
        public Bolum()
        {

        }
        public Bolum( string bolum_ID, string bolum_adi) {
            this.bolum_adi = bolum_adi;
            this.bolum_ID = bolum_ID;

                }
        
       private static Dictionary<string, Ders> DersListe = new Dictionary<string, Ders>();
        public static Dictionary<string,Ders> GetDers
        {
            get
            {
                return DersListe;
            }
        }


        public void Dersekle(string ders_id, Ders d)
        {
         DersListe.Add(ders_id, d);
        }
        public void DersSil(string ders_id)
        {
            DersListe.Remove(ders_id);
        }

       private static Dictionary<string, Ogrenci> OgrListe = new Dictionary<string, Ogrenci>();
        public static Dictionary<string, Ogrenci> GetOgrenci
        {
            get { return OgrListe; }
        }

        public void OgrEkle(string ogr_id, Ogrenci o)
        {

            OgrListe.Add(ogr_id,o);
        }
        public void OgrSil(string ders_id)
        {
            DersListe.Remove(ders_id);
        }

        public void hocaekle()
        {

        }
        public void hocasil()
        {

        }


    }
}
