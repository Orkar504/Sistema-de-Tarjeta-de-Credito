using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("tarjeta")]
    [Index("NumeroTarjeta", Name = "tarjeta_numero_tarjeta_key", IsUnique = true)]
    public partial class Tarjetum
    {
        public Tarjetum()
        {
            Extrafinanciamientos = new HashSet<Extrafinanciamiento>();
            SolicitudTarjeta = new HashSet<SolicitudTarjetum>();
            Transacciones = new HashSet<Transaccione>();
        }

        [Key]
        [Column("tarjeta_id")]
        public int TarjetaId { get; set; }
        [Column("pin")]
        [StringLength(4)]
        public string Pin { get; set; } = null!;
        [Column("cvc")]
        [StringLength(3)]
        public string Cvc { get; set; } = null!;
        [Column("numero_tarjeta")]
        [StringLength(16)]
        public string NumeroTarjeta { get; set; } = null!;
        [Column("fecha_emision")]
        public DateOnly? FechaEmision { get; set; }
        [Column("fecha_vencimiento")]
        public DateOnly? FechaVencimiento { get; set; }
        [Column("costo_membresia")]
        public double CostoMembresia { get; set; }
        [Column("interes_anual")]
        public double InteresAnual { get; set; }
        [Column("interes_mensual")]
        public double InteresMensual { get; set; }
        [Column("compania_id")]
        public int CompaniaId { get; set; }
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        [Column("sucursal_id")]
        public int SucursalId { get; set; }
        [Column("cuentaid")]
        public int Cuentaid { get; set; }

        [ForeignKey("ClienteId")]
        [InverseProperty("Tarjeta")]
        public virtual Cliente Cliente { get; set; } = null!;
        [ForeignKey("CompaniaId")]
        [InverseProperty("Tarjeta")]
        public virtual CompaniaTarjetum Compania { get; set; } = null!;
        [ForeignKey("Cuentaid")]
        [InverseProperty("Tarjeta")]
        public virtual Cuentum Cuenta { get; set; } = null!;
        [ForeignKey("SucursalId")]
        [InverseProperty("Tarjeta")]
        public virtual Sucursal Sucursal { get; set; } = null!;
        [InverseProperty("Tarjeta")]
        public virtual ICollection<Extrafinanciamiento> Extrafinanciamientos { get; set; }
        [InverseProperty("Tarjeta")]
        public virtual ICollection<SolicitudTarjetum> SolicitudTarjeta { get; set; }
        [InverseProperty("Tarjeta")]
        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
