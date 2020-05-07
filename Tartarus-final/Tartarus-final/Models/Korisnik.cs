using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Korisnik : Osoba
    {
        
        public String Email { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public DateTime DatumPrijave  { get; set; }
     
        public Korisnik(int id,String ime,String prezime,String email,String lozinka,DateTime datum) : base(id, ime, prezime)
        {
            Email = email;
            Username = email;
            Password = lozinka;
            DatumPrijave = datum;
        }
    }
}
