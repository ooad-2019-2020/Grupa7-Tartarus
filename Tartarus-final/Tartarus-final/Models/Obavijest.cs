using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Obavijest
    {
        public int Id { get; set; }
        public String Tekst { get; set; }
        public virtual ICollection<Obavijest> Obavijesti { get; set; }

        public Obavijest()
        {
            
        }
    }
}
