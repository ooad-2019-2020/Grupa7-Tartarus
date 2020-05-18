using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class Poruka
    {
        public int Id { get; set; }
        public String Tekst { get; set; }
        public String PrimalacEmail { get; set; }
        public String posiljalacEmail { get; set; }

        public virtual ICollection<Poruka> Poruke { get; set; }
        public Poruka()
        {

        }
    }
}
