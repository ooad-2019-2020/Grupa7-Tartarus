using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus.Models
{
    public class Zatvor
    {
        private int kapacitetZatvorenika;
        private double trosakPoZatvoreniku;
        private List<Zatvorenik> zatvorenici;
        private List<Cuvar> cuvari;
        private Upravnik upravnik;
    }
}
