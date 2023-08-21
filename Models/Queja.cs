using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("quejas")]
    public partial class Queja
    {
        [Key]
        [Column("quejas_id")]
        public int QuejasId { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string? Descripcion { get; set; }
        [Column("fecha")]
        public DateOnly? Fecha { get; set; }
        [Column("cliente_id")]
        public int? ClienteId { get; set; }
        [Column("empleado_id")]
        public int? EmpleadoId { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("Quejas")]
        public virtual Cliente? Cliente { get; set; }
        [ForeignKey("EmpleadoId")]
        [InverseProperty("Quejas")]
        public virtual Empleado? Empleado { get; set; }
    }
}
