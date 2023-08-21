using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("comite")]
    public partial class Comite
    {
        public Comite()
        {
            EstadoSolicituds = new HashSet<EstadoSolicitud>();
        }

        [Key]
        [Column("comite_id")]
        public int ComiteId { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string? Descripcion { get; set; }

        [InverseProperty("Comite")]
        public virtual ICollection<EstadoSolicitud> EstadoSolicituds { get; set; }
    }
}
