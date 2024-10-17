using WebGestionConsolas.Models;
using WebGestionConsolas.Service.Interface;
using Microsoft.EntityFrameworkCore;
namespace WebGestionConsolas.Service
{
    public class PlataformaService : IPlataformaService
    {
        private readonly AppDbContext _context;

        public PlataformaService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Plataforma>> GetAllPlataformasAsync()
        {
            return await _context.Plataformas.Include(p => p.Videojuegos).ToListAsync();
        }

        public async Task<Plataforma> GetPlataformaByIdAsync(int id)
        {
            return await _context.Plataformas.Include(p => p.Videojuegos)
                                             .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddPlataformaAsync(Plataforma plataforma)
        {
            _context.Plataformas.Add(plataforma);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePlataformaAsync(Plataforma plataforma)
        {
            _context.Plataformas.Update(plataforma);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePlataformaAsync(int id)
        {
            var plataforma = await _context.Plataformas.FindAsync(id);
            if (plataforma != null)
            {
                _context.Plataformas.Remove(plataforma);
                await _context.SaveChangesAsync();
            }
        }
    }
}
