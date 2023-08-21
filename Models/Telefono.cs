using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("telefono")]
    [Index("NumTelefono", Name = "telefono_num_telefono_key", IsUnique = true)]
    public partial class Telefono
    {
        [Column("num_telefono")]
        [StringLength(8)]
        public string NumTelefono { get; set; } = null!;
        [Column("persona_id", TypeName = "character varying")]
        public string PersonaId { get; set; } = null!;
        [Key]
        [Column("TelefonoID")]
        public long TelefonoId { get; set; }
        [Column("pais_id")]
        public int PaisId { get; set; }

        [ForeignKey("PaisId")]
        [InverseProperty("Telefonos")]
        public virtual Pai Pais { get; set; } = null!;
        [ForeignKey("PersonaId")]
        [InverseProperty("Telefonos")]
        public virtual Persona Persona { get; set; } = null!;
    }
}
