using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name: "rel_autores_libros")]
    public class RelAutorLibro
    {
        [Column(name: "id_autor")]
        public long AutorId { get; set; }
        public Autor Autor { get; set; }
        [Column(name: "id_libro")]
        public long LibroId { get; set; }
        public Libro Libro { get; set; }

        public RelAutorLibro(long autorId, long libroId)
        {
            AutorId = autorId;
            LibroId = libroId;
        }
    }
}
