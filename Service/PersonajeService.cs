using WebGestionConsolas.Data.Interface;
using WebGestionConsolas.Models;
using Microsoft.EntityFrameworkCore;
namespace WebGestionConsolas.Data
{
    public class PersonajeService : IPersonajeService
    {
        private readonly AppDbContext _context;

        public PersonajeService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Personaje>> GetAllPersonajesAsync()
        {
            return await _context.Personajes.Include(p => p.Videojuego).ToListAsync();
        }

        public async Task<Personaje> GetPersonajeByIdAsync(int id)
        {
            return await _context.Personajes.Include(p => p.Videojuego)
                                             .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task AddPersonajeAsync(Personaje personaje)
        {
            _context.Personajes.Add(personaje);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePersonajeAsync(Personaje personaje)
        {
            _context.Personajes.Update(personaje);
            await _context.SaveChangesAsync();
        }

        public async Task DeletePersonajeAsync(int id)
        {
            var personaje = await _context.Personajes.FindAsync(id);
            if (personaje != null)
            {
                _context.Personajes.Remove(personaje);
                await _context.SaveChangesAsync();
            }
        }
    }
}
