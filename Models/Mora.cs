using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("mora")]
    public partial class Mora
    {
        [Key]
        [Column("moraid")]
        public int Moraid { get; set; }
        [Column("fecha")]
        public DateOnly? Fecha { get; set; }
        [Column("meses")]
        public int? Meses { get; set; }
        [Column("monto_adecuado")]
        [Precision(10, 2)]
        public decimal? MontoAdecuado { get; set; }
        [Column("cliente_id")]
        public int? ClienteId { get; set; }
        [Column("estatusid")]
        public int? Estatusid { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("Moras")]
        public virtual Cliente? Cliente { get; set; }
        [ForeignKey("Estatusid")]
        [InverseProperty("Moras")]
        public virtual Estatus? Estatus { get; set; }
    }
}
