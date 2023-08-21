using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("datos_laborales")]
    public partial class DatosLaborale
    {
        public DatosLaborale()
        {
            Clientes = new HashSet<Cliente>();
        }

        [Column("ingreso_mensual")]
        [Precision(10, 2)]
        public decimal? IngresoMensual { get; set; }
        [Column("ocupacion_id")]
        public int OcupacionId { get; set; }
        [Column("Fecha_ingreo")]
        public DateOnly? FechaIngreo { get; set; }
        [Column("cargo")]
        [StringLength(50)]
        public string? Cargo { get; set; }
        [Key]
        [Column("datos_laborales_id")]
        public long DatosLaboralesId { get; set; }

        [ForeignKey("OcupacionId")]
        [InverseProperty("DatosLaborales")]
        public virtual Ocupacion Ocupacion { get; set; } = null!;
        [InverseProperty("DatosLaborales")]
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
