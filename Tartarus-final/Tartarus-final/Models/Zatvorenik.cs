using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Zatvorenik : Osoba
    {
       
        public Sektor sektor { get; set; }
        public int ZatvorskaKazna { get; set; }
        public List<Prekrsaj> Prekrsaji { get; set; }
        public String Evaluacija { get; set; }
        public int Jmbg { get; set; }
        public Zatvorenik(int id,String i,String p, Sektor s,int zk,List<Prekrsaj> pk,String ev,int jm) : base(id, i, p)
        {
            sektor = s;
            ZatvorskaKazna = zk;
            Prekrsaji = pk;
            Evaluacija = ev;
            Jmbg = jm;
        }
    }
}
