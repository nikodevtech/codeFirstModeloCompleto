using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name:"estados_prestamos")]
    public class EstadoPrestamo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_estado_prestamo { get; set; }
        public string? codigo_estado_prestamo { get; set; }
        public string? descripcion_estado_prestamo { get; set; }

        public ICollection<Prestamo> Prestamos { get; set; }

        public EstadoPrestamo(string? codigo_estado_prestamo, string? descripcion_estado_prestamo)
        {
            this.codigo_estado_prestamo = codigo_estado_prestamo;
            this.descripcion_estado_prestamo = descripcion_estado_prestamo;
        }
    }
}
