using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("solicitud_tarjeta")]
    public partial class SolicitudTarjetum
    {
        [Key]
        [Column("solicitud_id")]
        public int SolicitudId { get; set; }
        [Column("persona_id", TypeName = "character varying")]
        public string PersonaId { get; set; } = null!;
        [Column("direccion_id")]
        public long DireccionId { get; set; }
        [Column("sucursal_id")]
        public int SucursalId { get; set; }
        [Column("tarjeta_id")]
        public int TarjetaId { get; set; }
        [Column("fecha_solicitud")]
        public DateOnly? FechaSolicitud { get; set; }
        [Column("estado_solicitudid")]
        public int EstadoSolicitudid { get; set; }

        [ForeignKey("DireccionId")]
        [InverseProperty("SolicitudTarjeta")]
        public virtual Direccion Direccion { get; set; } = null!;
        [ForeignKey("EstadoSolicitudid")]
        [InverseProperty("SolicitudTarjeta")]
        public virtual EstadoSolicitud EstadoSolicitud { get; set; } = null!;
        [ForeignKey("PersonaId")]
        [InverseProperty("SolicitudTarjeta")]
        public virtual Persona Persona { get; set; } = null!;
        [ForeignKey("SucursalId")]
        [InverseProperty("SolicitudTarjeta")]
        public virtual Sucursal Sucursal { get; set; } = null!;
        [ForeignKey("TarjetaId")]
        [InverseProperty("SolicitudTarjeta")]
        public virtual Tarjetum Tarjeta { get; set; } = null!;
    }
}
