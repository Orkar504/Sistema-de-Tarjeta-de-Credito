using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("pais")]
    [Index("NombrePais", Name = "pais_nombre_pais_key", IsUnique = true)]
    public partial class Pai
    {
        public Pai()
        {
            Departamentos = new HashSet<Departamento>();
            Direccions = new HashSet<Direccion>();
            Telefonos = new HashSet<Telefono>();
        }

        [Key]
        [Column("pais_id")]
        public int PaisId { get; set; }
        [Column("nombre_pais")]
        [StringLength(50)]
        public string NombrePais { get; set; } = null!;

        [InverseProperty("Pais")]
        public virtual ICollection<Departamento> Departamentos { get; set; }
        [InverseProperty("Pais")]
        public virtual ICollection<Direccion> Direccions { get; set; }
        [InverseProperty("Pais")]
        public virtual ICollection<Telefono> Telefonos { get; set; }
    }
}
