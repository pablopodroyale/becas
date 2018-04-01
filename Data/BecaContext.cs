using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Beca.Models
{
    public class BecaContext : DbContext
    {
        public BecaContext (DbContextOptions<BecaContext> options)
            : base(options)
        {
        }

        public DbSet<Beca.Models.Encuesta> Encuesta { get; set; }
    }
}
