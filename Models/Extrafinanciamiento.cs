using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("extrafinanciamiento")]
    public partial class Extrafinanciamiento
    {
        [Key]
        [Column("extrafinanciamiento_id")]
        public int ExtrafinanciamientoId { get; set; }
        [Column("interes_anual")]
        public double? InteresAnual { get; set; }
        [Column("interes_mensual")]
        public double? InteresMensual { get; set; }
        [Column("pago_total")]
        public double? PagoTotal { get; set; }
        [Column("pago_mensual")]
        public double? PagoMensual { get; set; }
        [Column("tarjeta_id")]
        public int? TarjetaId { get; set; }

        [ForeignKey("TarjetaId")]
        [InverseProperty("Extrafinanciamientos")]
        public virtual Tarjetum? Tarjeta { get; set; }
    }
}
