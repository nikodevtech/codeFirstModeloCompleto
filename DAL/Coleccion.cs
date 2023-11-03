using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name: "colecciones")]
    public class Coleccion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_coleccion { get; set; }
        public string? nombre_coleccion { get; set; }

        public ICollection<Libro> Libros { get; set; }

        public Coleccion(string? nombre_coleccion)
        {
            this.nombre_coleccion = nombre_coleccion;
        }
    }
}
