using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("telefonosucursal")]
    [Index("NumTelefono", Name = "telefonosucursal_num_telefono_key", IsUnique = true)]
    public partial class Telefonosucursal
    {
        [Key]
        [Column("telefonoid")]
        public int Telefonoid { get; set; }
        [Column("num_telefono")]
        [StringLength(8)]
        public string NumTelefono { get; set; } = null!;
        [Column("sucursal_id")]
        public int SucursalId { get; set; }

        [ForeignKey("SucursalId")]
        [InverseProperty("Telefonosucursals")]
        public virtual Sucursal Sucursal { get; set; } = null!;
    }
}
