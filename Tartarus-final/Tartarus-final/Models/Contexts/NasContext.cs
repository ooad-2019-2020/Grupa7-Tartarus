using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
        public DbSet<Zatvorenik> Zatvorenik { get; set; }
       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Poruka>().ToTable("Poruke");
            modelBuilder.Entity<Obavijest>().ToTable("Obavijesti");
            modelBuilder.Entity<Zatvorenik>().ToTable("Zatvorenik");
        }

    }
}
