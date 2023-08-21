using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("estado_solicitud")]
    public partial class EstadoSolicitud
    {
        public EstadoSolicitud()
        {
            SolicitudTarjeta = new HashSet<SolicitudTarjetum>();
        }

        [Key]
        [Column("estado_solicitudid")]
        public int EstadoSolicitudid { get; set; }
        [Column("estadoid")]
        public int? Estadoid { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string? Descripcion { get; set; }
        [Column("fecha")]
        public DateOnly? Fecha { get; set; }
        [Column("comite_id")]
        public int? ComiteId { get; set; }

        [ForeignKey("ComiteId")]
        [InverseProperty("EstadoSolicituds")]
        public virtual Comite? Comite { get; set; }
        [ForeignKey("Estadoid")]
        [InverseProperty("EstadoSolicituds")]
        public virtual Estado? Estado { get; set; }
        [InverseProperty("EstadoSolicitud")]
        public virtual ICollection<SolicitudTarjetum> SolicitudTarjeta { get; set; }
    }
}
