using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Keyless]
    [Table("comitexempleado")]
    public partial class Comitexempleado
    {
        [Column("empleado_id")]
        public int? EmpleadoId { get; set; }
        [Column("comite_id")]
        public int? ComiteId { get; set; }

        [ForeignKey("ComiteId")]
        public virtual Comite? Comite { get; set; }
        [ForeignKey("EmpleadoId")]
        public virtual Empleado? Empleado { get; set; }
    }
}
