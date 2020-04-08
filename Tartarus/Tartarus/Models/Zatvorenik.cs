using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus.Models
{
    public class Zatvorenik : Osoba
    {
        public int zatvorskaKazna;
        public List<Prekrsaj> prekrsaji;
        public String evaluacijaPonasanja;
    }
}
