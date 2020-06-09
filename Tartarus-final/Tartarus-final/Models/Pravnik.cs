using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Pravnik : Korisnik
    {
        public Pravnik(int id, String i, String p, String u, String em, String loz, DateTime dp, String pro) : base(id, i, p, u, em, loz, dp)
        {
            Profesija = pro;
        }
        public String Profesija { get; set; }
    }
}
