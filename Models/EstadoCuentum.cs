using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("estado_cuenta")]
    public partial class EstadoCuentum
    {
        [Key]
        [Column("estado_cuenta_id")]
        public int EstadoCuentaId { get; set; }
        [Column("num_cuenta")]
        [StringLength(10)]
        public string NumCuenta { get; set; } = null!;
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        [Column("cuenta_id")]
        public int CuentaId { get; set; }
        [Column("pago_minimo")]
        [Precision(10, 2)]
        public decimal? PagoMinimo { get; set; }
        [Column("pago_total")]
        [Precision(10, 2)]
        public decimal? PagoTotal { get; set; }
        [Column("plazo_meses")]
        public int? PlazoMeses { get; set; }
        [Column("puntos_totales")]
        public int? PuntosTotales { get; set; }
        [Column("puntos_obtenidos")]
        public int? PuntosObtenidos { get; set; }
        [Column("limite_credito")]
        [Precision(10, 2)]
        public decimal LimiteCredito { get; set; }
        [Column("credito_disponible")]
        [Precision(10, 2)]
        public decimal CreditoDisponible { get; set; }
        [Column("fecha_maxima_pago")]
        public DateOnly? FechaMaximaPago { get; set; }
        [Column("fecha_corte")]
        public DateOnly? FechaCorte { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("EstadoCuenta")]
        public virtual Cliente Cliente { get; set; } = null!;
        [ForeignKey("CuentaId")]
        [InverseProperty("EstadoCuenta")]
        public virtual Cuentum Cuenta { get; set; } = null!;
    }
}
