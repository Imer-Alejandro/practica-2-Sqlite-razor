using WebGestionConsolas.Models;

namespace WebGestionConsolas.Service.Interface
{
    public interface IPlataformaService
    {
        Task<IEnumerable<Plataforma>> GetAllPlataformasAsync();
        Task<Plataforma> GetPlataformaByIdAsync(int id);
        Task AddPlataformaAsync(Plataforma plataforma);
        Task UpdatePlataformaAsync(Plataforma plataforma);
        Task DeletePlataformaAsync(int id);
    }
}
