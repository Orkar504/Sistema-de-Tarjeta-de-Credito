using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("cuenta")]
    [Index("NumCuenta", Name = "cuenta_num_cuenta_key", IsUnique = true)]
    public partial class Cuentum
    {
        public Cuentum()
        {
            EstadoCuenta = new HashSet<EstadoCuentum>();
            Tarjeta = new HashSet<Tarjetum>();
        }

        [Key]
        [Column("cuenta_id")]
        public int CuentaId { get; set; }
        [Column("num_cuenta")]
        [StringLength(10)]
        public string NumCuenta { get; set; } = null!;
        [Column("saldo")]
        [Precision(10, 2)]
        public decimal Saldo { get; set; }
        [Column("cliente_id")]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("Cuenta")]
        public virtual Cliente Cliente { get; set; } = null!;
        [InverseProperty("Cuenta")]
        public virtual ICollection<EstadoCuentum> EstadoCuenta { get; set; }
        [InverseProperty("Cuenta")]
        public virtual ICollection<Tarjetum> Tarjeta { get; set; }
    }
}
