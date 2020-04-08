using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus.Models
{
    public class Osoba
    {
        public String id;
        public String ime;
        public String prezime;
        public String email;
        public String lozinka;
        public DateTime datumPrijave;
        public Zatvor zatvor;
    }
}
