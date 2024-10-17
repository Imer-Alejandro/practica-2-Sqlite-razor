namespace WebGestionConsolas.Models
{
    public class Videojuego
    {
        public int Id { get; set; }  
        public string Nombre { get; set; }
        public string Desarrollador { get; set; }
        public string Genero { get; set; }
        public DateTime FechaLanzamiento { get; set; }
        public string ImagenPortadaUrl { get; set; }
        public string Descripcion { get; set; }

        // Relación uno a muchos con Plataforma
        public int PlataformaId { get; set; }
        public Plataforma Plataforma { get; set; }

        // Relación uno a muchos con Personaje
        public ICollection<Personaje> Personajes { get; set; }
    }
}
