using WebGestionConsolas.Models;
using WebGestionConsolas.Service.Interface;
using Microsoft.EntityFrameworkCore;
namespace WebGestionConsolas.Service
{
    public class VideojuegoService : IVideojuegoService
    {
        private readonly AppDbContext _context;

        public VideojuegoService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Videojuego>> GetAllVideojuegosAsync()
        {
            return await _context.Videojuegos.Include(v => v.Plataforma)
                                             .Include(v => v.Personajes)
                                             .ToListAsync();
        }

        public async Task<Videojuego> GetVideojuegoByIdAsync(int id)
        {
            return await _context.Videojuegos.Include(v => v.Plataforma)
                                             .Include(v => v.Personajes)
                                             .FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task AddVideojuegoAsync(Videojuego videojuego)
        {
            _context.Videojuegos.Add(videojuego);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateVideojuegoAsync(Videojuego videojuego)
        {
            _context.Videojuegos.Update(videojuego);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteVideojuegoAsync(int id)
        {
            var videojuego = await _context.Videojuegos.FindAsync(id);
            if (videojuego != null)
            {
                _context.Videojuegos.Remove(videojuego);
                await _context.SaveChangesAsync();
            }
        }
    }
}
