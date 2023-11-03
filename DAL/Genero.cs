using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name: "generos")]
    public class Genero
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_genero { get; set; }
        public string? nombre_genero { get; set; }
        public string? descripcion_genero { get; set; }

        public ICollection<Libro> Libros { get; set; }

        public Genero(string? nombre_genero, string? descripcion_genero)
        {
            this.nombre_genero = nombre_genero;
            this.descripcion_genero = descripcion_genero;
        }
    }
}
