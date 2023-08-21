using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("municipio")]
    [Index("DepartamentoId", Name = "municipio_departamento_id_key", IsUnique = true)]
    public partial class Municipio
    {
        public Municipio()
        {
            Ciudads = new HashSet<Ciudad>();
            Direccions = new HashSet<Direccion>();
        }

        [Key]
        [Column("municipio_id")]
        public long MunicipioId { get; set; }
        [Column("nombre_municipio")]
        [StringLength(50)]
        public string NombreMunicipio { get; set; } = null!;
        [Column("departamento_id")]
        public int DepartamentoId { get; set; }

        [ForeignKey("DepartamentoId")]
        [InverseProperty("Municipio")]
        public virtual Departamento Departamento { get; set; } = null!;
        [InverseProperty("Municipio")]
        public virtual ICollection<Ciudad> Ciudads { get; set; }
        [InverseProperty("Municipio")]
        public virtual ICollection<Direccion> Direccions { get; set; }
    }
}
