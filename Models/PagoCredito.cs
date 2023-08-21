using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("pago_credito")]
    public partial class PagoCredito
    {
        [Key]
        [Column("pago_creditoid")]
        public int PagoCreditoid { get; set; }
        [Column("fecha")]
        public DateOnly? Fecha { get; set; }
        [Column("hora")]
        public TimeOnly? Hora { get; set; }
        [Column("pago")]
        [Precision(10, 2)]
        public decimal? Pago { get; set; }
        [Column("cliente_id")]
        public int? ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("PagoCreditos")]
        public virtual Cliente? Cliente { get; set; }
    }
}
