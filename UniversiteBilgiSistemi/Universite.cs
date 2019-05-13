using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversiteBilgiSistemi
{
    class Universite

    {
       private static Dictionary<string, Fakulte> FakulteListe = new Dictionary<string,Fakulte>();
        public static Dictionary<string, Fakulte> GetFakulte
        {
            get { return FakulteListe; }
        }
       
        public void fakulteekle(string faklteId,Fakulte f)
        {
            
            FakulteListe.Add(faklteId,new Fakulte(f.Fklte_ID,f.Fklteadi));
        }
        

    }
}
