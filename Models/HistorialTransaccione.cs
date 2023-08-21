using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("historial_transacciones")]
    public partial class HistorialTransaccione
    {
        [Key]
        [Column("historial_transaccionesid")]
        public int HistorialTransaccionesid { get; set; }
        [Column("debito_compra")]
        [Precision(10, 2)]
        public decimal? DebitoCompra { get; set; }
        [Column("credito_compra")]
        [Precision(10, 2)]
        public decimal? CreditoCompra { get; set; }
        [Column("limite_integrado")]
        [Precision(10, 2)]
        public decimal LimiteIntegrado { get; set; }
        [Column("credito_disponible")]
        [Precision(10, 2)]
        public decimal CreditoDisponible { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string? Descripcion { get; set; }
        [Column("transaccion_id")]
        public int TransaccionId { get; set; }

        [ForeignKey("TransaccionId")]
        [InverseProperty("HistorialTransacciones")]
        public virtual Transaccione Transaccion { get; set; } = null!;
    }
}
