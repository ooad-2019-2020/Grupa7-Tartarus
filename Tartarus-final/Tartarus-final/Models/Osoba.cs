using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Osoba
    {
       
        public int Id { get; set; }
        public String Ime { get; set; }
        public String Prezime { get; set; }
        public Osoba(int id, String ime, String prezime)
        {
            Id = id;
            Ime = ime;
            Prezime = prezime;
           }
    }
}
