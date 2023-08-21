using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("estado")]
    public partial class Estado
    {
        public Estado()
        {
            EstadoSolicituds = new HashSet<EstadoSolicitud>();
        }

        [Key]
        [Column("estadoid")]
        public int Estadoid { get; set; }
        [Column("descripcion")]
        [StringLength(15)]
        public string? Descripcion { get; set; }

        [InverseProperty("Estado")]
        public virtual ICollection<EstadoSolicitud> EstadoSolicituds { get; set; }
    }
}
