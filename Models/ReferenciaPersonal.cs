using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("referencia_personal")]
    public partial class ReferenciaPersonal
    {
        [Column("persona_id", TypeName = "character varying")]
        public string? PersonaId { get; set; }
        [Key]
        [Column("referencia_id")]
        public int ReferenciaId { get; set; }

        [ForeignKey("PersonaId")]
        [InverseProperty("ReferenciaPersonals")]
        public virtual Persona? Persona { get; set; }
    }
}
