using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus_final.Models
{
    public class NasContext : DbContext
    {
        public NasContext(DbContextOptions<NasContext> options) : base(options)
        {

        }
   
        public DbSet<Obavijest> Obavijest { get; set; }
        public DbSet<Poruka> Poruka { get; set; }
    }
}
