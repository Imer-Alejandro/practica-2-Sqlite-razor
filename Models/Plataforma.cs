namespace WebGestionConsolas.Models
{
    public class Plataforma
    {
        public int Id { get; set; }  
        public string Nombre { get; set; }
        public bool Activa { get; set; }

        // Relación uno a muchos con Videojuego
        public ICollection<Videojuego> Videojuegos { get; set; }
    }
}
