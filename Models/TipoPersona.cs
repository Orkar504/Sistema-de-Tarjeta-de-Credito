using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("tipo_persona")]
    public partial class TipoPersona
    {
        public TipoPersona()
        {
            Personas = new HashSet<Persona>();
        }

        [Key]
        [Column("tipo_personaid")]
        public int TipoPersonaid { get; set; }
        [Column("descripcion")]
        [StringLength(50)]
        public string? Descripcion { get; set; }

        [InverseProperty("TipoPersona")]
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
