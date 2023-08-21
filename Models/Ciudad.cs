using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("ciudad")]
    public partial class Ciudad
    {
        public Ciudad()
        {
            Direccions = new HashSet<Direccion>();
            Transacciones = new HashSet<Transaccione>();
        }

        [Key]
        [Column("ciudad_id")]
        public long CiudadId { get; set; }
        [Column("municipio_id")]
        public long MunicipioId { get; set; }
        [Column("nombre_ciudad")]
        [StringLength(50)]
        public string NombreCiudad { get; set; } = null!;

        [ForeignKey("MunicipioId")]
        [InverseProperty("Ciudads")]
        public virtual Municipio Municipio { get; set; } = null!;
        [InverseProperty("Cuidad")]
        public virtual ICollection<Direccion> Direccions { get; set; }
        [InverseProperty("Ciudad")]
        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
