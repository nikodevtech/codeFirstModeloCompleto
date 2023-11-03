using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Table(name:"prestamos")]
    public class Prestamo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long id_prestamo { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_inicio_prestamo { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_fin_prestamo { get; set; }
        [Column(TypeName = "timestamp without time zone")]
        public DateTime? fch_entrega_prestamo { get; set; }

        [Column(name: "id_estado_prestamo")]
        public long EstadoPrestamoId { get; set; }
        public EstadoPrestamo EstadoPrestamo { get; set; }

        [Column(name: "id_usuario")]
        public long UsuarioId { get; set; }
        public Usuario Usuario { get; set; }

        public ICollection<RelPrestamoLibro> RelPrestamoLibros { get; set; }

        // Constructor

        public Prestamo(DateTime? fch_inicio_prestamo, DateTime? fch_fin_prestamo, DateTime? fch_entrega_prestamo, long estadoPrestamoId, long usuarioId)
        {
            this.fch_inicio_prestamo = fch_inicio_prestamo;
            this.fch_fin_prestamo = fch_fin_prestamo;
            this.fch_entrega_prestamo = fch_entrega_prestamo;
            EstadoPrestamoId = estadoPrestamoId;
            UsuarioId = usuarioId;
        }
    }
}
