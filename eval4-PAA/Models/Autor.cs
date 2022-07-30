using System.ComponentModel.DataAnnotations.Schema;

namespace eval4_PAA.Models
{
    [Table("Autor")]
    public class Autor
    {
        //Album =>Autor
        //Cancion => Libro
        public int? Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool? EstaVivo { get; set; }

        // Relaciones
        public virtual ICollection<Libro>? Libros { get; set; }

    }
}
