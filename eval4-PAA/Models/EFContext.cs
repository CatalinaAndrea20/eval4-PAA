using Microsoft.EntityFrameworkCore;

namespace eval4_PAA.Models
{
    public class EFContext : DbContext
    {
        // 1. Crear atributo que almacene la cadena de conexión a la BD
        private const string ConnectionString = "server=localhost;port=3306;database=eval4_db;user=root;password=;Connect Timeout=5;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(ConnectionString,
                new MySqlServerVersion(new Version(8, 0, 11)));
        }

        public DbSet<Autor> Autores { get; set; }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Album =>Autor
            //Cancion => Libro
            // Claves primarias
            modelBuilder.Entity<Libro>().HasKey(i => i.Id);
            modelBuilder.Entity<Autor>().HasKey(j => j.Id);

            //Relacion uno a muchos
            modelBuilder.Entity<Libro>()
                .HasOne(s => s.Autor)
                .WithMany(g => g.Libros)
                .HasForeignKey(c => c.AutorId);

            //Mandatorio clase Libro

            modelBuilder.Entity<Libro>().Property(s => s.AutorId).IsRequired();
            modelBuilder.Entity<Libro>().Property(s => s.Titulo).IsRequired();
            modelBuilder.Entity<Libro>().Property(s => s.Paginas).IsRequired();

            //Mandatorio clase Autor

            modelBuilder.Entity<Autor>().Property(s => s.Nombre).IsRequired();
            modelBuilder.Entity<Autor>().Property(s => s.FechaNacimiento)
                .HasDefaultValue(DateTime.Now) // Indicar un valor por defecto
                .IsRequired();

        }

    }
}
