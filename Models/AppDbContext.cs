using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace WebGestionConsolas.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Videojuego> Videojuegos { get; set; }
        public DbSet<Personaje> Personajes { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relaciones entre Videojuegos y Personajes
            modelBuilder.Entity<Videojuego>()
                .HasMany(v => v.Personajes)
                .WithOne(p => p.Videojuego)
                .HasForeignKey(p => p.VideojuegoId);

            // Otros mapeos o configuraciones
        }
    }
}
