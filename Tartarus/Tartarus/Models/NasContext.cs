using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tartarus.Models
{
    public class NasContext : DbContext
    {
        public NasContext(DbContextOptions<NasContext> options) : base(options)
        {

        }
    }
}
