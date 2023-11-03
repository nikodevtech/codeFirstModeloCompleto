using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar la clave primaria compuesta por dos FK en tablas intermedias en este ejemplo RelAutorLibro.

            // modelBuilder.Entity<RelAutorLibro>(): Esta parte se refiere a la configuración de la entidad RelAutorLibro
            // utilizando el objeto modelBuilder que se utiliza para configurar la estructura de la base de datos y cómo
            // se mapean las entidades a las tablas de la base de datos.

            // .HasKey(x => new { x.AutorId, x.LibroId }): Esta parte es donde se define la PK de la entidad RelAutorLibro.
            // Aquí, se está utilizando una expresión lambda (x => new { x.AutorId, x.LibroId }) para configurar la PK compuesta.

            // En esta expresión lambda: x es un parámetro que representa una instancia de la entidad RelAutorLibro.
            // x.AutorId y x.LibroId son propiedades de la entidad RelAutorLibro, que se utilizan para definir la PK compuesta

            modelBuilder.HasDefaultSchema("gbp_operacional"); //Schema al que apunta
            modelBuilder.UseSerialColumns(); // Indica que sean PK AutoIncrement en la BD
            modelBuilder.Entity<Usuario>().ToTable("usuarios"); //Alternativa para dar nombre especifico a la tabla
            modelBuilder.Entity<Acceso>().ToTable("accesos");
            modelBuilder.Entity<RelAutorLibro>().HasKey(r => new { r.AutorId, r.LibroId }); // Indica que la PK RelAutorLibro es la formada por dos FK AutorId y LibroId
            modelBuilder.Entity<RelPrestamoLibro>().HasKey(r => new { r.PrestamoId, r.LibroId });
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Acceso> Accesos { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Coleccion> Colecciones { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<EstadoPrestamo> EstadoPrestamos { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<RelAutorLibro> RelAutorLibros { get; set; }
        public DbSet<RelPrestamoLibro> RelPrestamoLibros { get; set; }

    }
}
