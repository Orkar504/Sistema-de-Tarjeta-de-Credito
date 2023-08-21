using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("tipo_documento")]
    public partial class TipoDocumento
    {
        public TipoDocumento()
        {
            Personas = new HashSet<Persona>();
        }

        [Key]
        [Column("tipo_documentoid")]
        public int TipoDocumentoid { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; } = null!;

        [InverseProperty("TipoDocumento")]
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
