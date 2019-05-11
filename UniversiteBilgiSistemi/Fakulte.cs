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
        public void bolumekle()
        {
           
        }
       public void save(string Dosyaadi)
        {
            using (var stream = new FileStream(Dosyaadi, FileMode.Create))
            {
                var xml = new XmlSerializer(typeof(Fakulte));
                xml.Serialize(stream, this);
                
            }
         
        }
            
    }
}
