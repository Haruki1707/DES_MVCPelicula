using System.ComponentModel.DataAnnotations;

namespace MVCPelicula.Models
{
    public class Pelicula
    {
        public int ID { get; set; }

        [StringLength(250)]
        [Required]
        public string Titulo { get; set; }
        public DateTime FechaLanzamiento { get; set; }

        [Required]
        public int? GeneroId { get; set; }
        public Genero? Genero { get; set; }

        [Required]
        public decimal Precio {  get; set; }

        [StringLength(250)]
        [Required]
        public string Director { get; set; }
    }
}
