using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Zatvor
    {
        public int MaxKapacitet { get; set; }
        public int BrojZatvorenika { get; set; }
        public Upravnik Upravnik { get; set; }
        public List<Sektor> Sektori { get; set; }
        public Zatvor()
        {

        }
    }
}
