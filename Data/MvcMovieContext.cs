
using Microsoft.EntityFrameworkCore;
using Mudanza1711.Models;

namespace Mudanza1711.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Bus> Bus { get; set; }

        public DbSet<Mudanza1711.Models.Camiones> Camiones { get; set; }

        public DbSet<Camion> Camion { get; set; }
        public DbSet<AltaCamiones> AltaCamiones { get; set; }
    }
}


