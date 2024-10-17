using WebGestionConsolas.Models;

namespace WebGestionConsolas.Service.Interface
{
    public interface IVideojuegoService
    {
        Task<IEnumerable<Videojuego>> GetAllVideojuegosAsync();
        Task<Videojuego> GetVideojuegoByIdAsync(int id);
        Task AddVideojuegoAsync(Videojuego videojuego);
        Task UpdateVideojuegoAsync(Videojuego videojuego);
        Task DeleteVideojuegoAsync(int id);
    }
}
