using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("compania_tarjeta")]
    public partial class CompaniaTarjetum
    {
        public CompaniaTarjetum()
        {
            Tarjeta = new HashSet<Tarjetum>();
        }

        [Key]
        [Column("compania_id")]
        public int CompaniaId { get; set; }
        [Column("nombre")]
        [StringLength(100)]
        public string Nombre { get; set; } = null!;
        [Column("cargo_de_compra")]
        [Precision(10, 2)]
        public decimal CargoDeCompra { get; set; }

        [InverseProperty("Compania")]
        public virtual ICollection<Tarjetum> Tarjeta { get; set; }
    }
}
