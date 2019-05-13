using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace UniversiteBilgiSistemi
{
   public class Fakulte
    {
        public String Fklteadi { get; set; }
        public string Fklte_ID { get; set; }

        public Fakulte()
        {

        }

        public Fakulte(string Fklteadi,string Fklte_ID)
        {
            this.Fklteadi = Fklteadi;
            this.Fklte_ID = Fklte_ID;
        }
        
        private static Dictionary<string, Bolum> BolumListe = new Dictionary<string, Bolum>();
        public static Dictionary<string,Bolum> GetBolum
        {
            get { return BolumListe; }
        }


        public void Bolumekle(string bolum_ID,Bolum b)
        {
            
            BolumListe.Add(bolum_ID,b);
        }

        
         
        }
            
    }

