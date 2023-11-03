using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name: "libros")]
    public class Libro
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_libro { get; set; }
        public string? isbn_libro { get; set; }
        public string? titulo_libro { get; set; }
        public string? edicion_libro { get; set; }
        public int? cantidad_libro { get; set; }

        [Column(name: "id_editorial")]
        public long EditorialId { get; set; }
        public Editorial Editorial { get; set; }
        [Column(name: "id_genero")]
        public long GeneroId { get; set; }
        public Genero Genero { get; set; }
        [Column(name: "id_coleccion")]
        public long ColeccionId { get; set; }
        public Coleccion Coleccion { get; set; }

        public ICollection<RelAutorLibro> RelAutorLibros { get; set; }
        public ICollection<RelPrestamoLibro> RelPrestamoLibros { get; set; }


        public Libro(string? isbn_libro, string? titulo_libro, string? edicion_libro, int? cantidad_libro
            , long editorialId, long generoId, long coleccionId)
        {
            this.isbn_libro = isbn_libro;
            this.titulo_libro = titulo_libro;
            this.edicion_libro = edicion_libro;
            this.cantidad_libro = cantidad_libro;
            EditorialId = editorialId;
            GeneroId = generoId;
            ColeccionId = coleccionId;
        }
    }
}
