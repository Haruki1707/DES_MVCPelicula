using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCPelicula.Models
{
    public class Pelicula
    {
        public int ID { get; set; }

        [StringLength(250, MinimumLength = 3)]
        [Required]
        [DisplayName("Titulo")]
        public string Titulo { get; set; }

        [DisplayName("Fecha de Lanzamiento")]
        [DataType(DataType.Date)]
        public DateTime FechaLanzamiento { get; set; }

        [Required]
        public int? GeneroId { get; set; }
        [DisplayName("Genero")]
        public Genero? Genero { get; set; }

        [Required]
        [Column(TypeName = "decimal(18, 2)")]
        [DataType(DataType.Currency)]
        [Range(1, 100)]
        public decimal Precio {  get; set; }

        [StringLength(250)]
        [Required]
        public string Director { get; set; }
    }
}
