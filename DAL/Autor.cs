using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name: "autores")]
    public class Autor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_autor { get; set; }
        public string? nombre_autor { get; set; }
        public string? apellidos_autor { get; set; }

        public ICollection<RelAutorLibro> RelAutorLibros { get; set; }

        public Autor(string? nombre_autor, string? apellidos_autor)
        {
            this.nombre_autor = nombre_autor;
            this.apellidos_autor = apellidos_autor;
        }
    }
}
