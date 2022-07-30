using System.ComponentModel.DataAnnotations.Schema;

namespace eval4_PAA.Models
{
    [Table("Libro")]
    public class Libro
    {
        //Album =>Autor
        //Cancion => Libro
        public int Id { get; set; }
        public int AutorId { get; set; }
        public string Titulo { get; set; }
        public int Paginas { get; set; }

        public virtual Autor Autor { get; set; }


    }

}
