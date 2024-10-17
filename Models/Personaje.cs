namespace WebGestionConsolas.Models
{
    public class Personaje
    {
        public int Id { get; set; }  
        public string Nombre { get; set; }
        public string Alias { get; set; }  
        public string RolEnJuego { get; set; }
        public string HabilidadEspecial { get; set; }  
        public string ArmaFavorita { get; set; }  
        public int NivelPoder { get; set; }
        public string ImagenUrl { get; set; }

        // Relación muchos a uno con Videojuego
        public int VideojuegoId { get; set; }
        public Videojuego Videojuego { get; set; }
    }
}
