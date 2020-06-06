using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Sektor
    {
        public int Id { get; set; }
        public String Naziv { get; set; }
        public Cuvar NadlezniCuvar { get; set; }

        public Sektor()
        {

        }
    }
}
