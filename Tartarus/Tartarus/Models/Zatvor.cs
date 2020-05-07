using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus.Models
{
    public class Zatvor
    {
        private int kapacitetZatvorenika { get; set; }
        private double trosakPoZatvoreniku { get; set; }
        private List<Zatvorenik> zatvorenici { get; set; }
        private List<Cuvar> cuvari { get; set; }
        private Upravnik upravnik { get; set; }
    }
}
