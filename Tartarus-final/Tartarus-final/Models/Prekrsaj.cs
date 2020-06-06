using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Prekrsaj
    {
        public int Id { get; set; }
        public String Zapisnik { get; set; }
        public String KaznenoDjelo { get; set; }
        public DateTime DatumPrekrsaja { get; set; }
        public DateTime DatumPritvora { get; set; }
        public DateTime DatumSudskeOdluke { get; set; }
        public Prekrsaj()
        {

        }
    }
}
