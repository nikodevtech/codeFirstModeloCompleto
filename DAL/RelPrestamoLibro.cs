using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name: "rel_prestamos_libros")]
    public class RelPrestamoLibro
    {
        [Column(name: "id_prestamo")]
        public long PrestamoId { get; set; }
        public Prestamo Prestamo { get; set; }
        [Column(name: "id_libro")]
        public long LibroId { get; set; }
        public Libro Libro { get; set; }


        public RelPrestamoLibro(long prestamoId, long libroId)
        {
            PrestamoId = prestamoId;
            LibroId = libroId;
        }
    }
}
