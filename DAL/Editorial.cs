using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name: "editoriales")]
    public class Editorial
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_editorial { get; set; }
        public string? nombre_editorial { get; set; }

        public ICollection<Libro> Libros { get; set; }

        public Editorial(string? nombre_editorial)
        {
            this.nombre_editorial = nombre_editorial;
        }
    }
}
