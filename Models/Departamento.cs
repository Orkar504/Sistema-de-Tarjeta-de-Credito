using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("departamento")]
    public partial class Departamento
    {
        public Departamento()
        {
            Direccions = new HashSet<Direccion>();
        }

        [Key]
        [Column("departamento_id")]
        public int DepartamentoId { get; set; }
        [Column("nombre_depto")]
        [StringLength(50)]
        public string NombreDepto { get; set; } = null!;
        [Column("zona")]
        [StringLength(50)]
        public string? Zona { get; set; }
        [Column("pais_id")]
        public int PaisId { get; set; }

        [ForeignKey("PaisId")]
        [InverseProperty("Departamentos")]
        public virtual Pai Pais { get; set; } = null!;
        [InverseProperty("Departamento")]
        public virtual Municipio? Municipio { get; set; }
        [InverseProperty("Departamento")]
        public virtual ICollection<Direccion> Direccions { get; set; }
    }
}
