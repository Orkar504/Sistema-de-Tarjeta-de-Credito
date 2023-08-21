using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("ocupacion")]
    [Index("Titulo", Name = "ocupacion_titulo_key", IsUnique = true)]
    public partial class Ocupacion
    {
        public Ocupacion()
        {
            DatosLaborales = new HashSet<DatosLaborale>();
        }

        [Key]
        [Column("ocupacion_id")]
        public int OcupacionId { get; set; }
        [Column("titulo")]
        [StringLength(50)]
        public string Titulo { get; set; } = null!;

        [InverseProperty("Ocupacion")]
        public virtual ICollection<DatosLaborale> DatosLaborales { get; set; }
    }
}
