using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Beca.Models;

namespace Beca.Data
{
    public class EncuestaContexto : DbContext
    {
        public EncuestaContexto (DbContextOptions<EncuestaContexto> options)
            : base(options)
        {
        }

        public DbSet<Beca.Models.Encuesta> Encuesta { get; set; }
    }
}
