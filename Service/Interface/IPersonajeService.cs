using WebGestionConsolas.Models;

namespace WebGestionConsolas.Data.Interface
{
    public interface IPersonajeService
    {
        Task<IEnumerable<Personaje>> GetAllPersonajesAsync();
        Task<Personaje> GetPersonajeByIdAsync(int id);
        Task AddPersonajeAsync(Personaje personaje);
        Task UpdatePersonajeAsync(Personaje personaje);
        Task DeletePersonajeAsync(int id);
    }
}
