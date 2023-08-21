using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("transacciones")]
    public partial class Transaccione
    {
        public Transaccione()
        {
            HistorialTransacciones = new HashSet<HistorialTransaccione>();
        }

        [Key]
        [Column("transaccionesid")]
        public int Transaccionesid { get; set; }
        [Column("tipo_transaccionid")]
        public int? TipoTransaccionid { get; set; }
        [Column("cantidad_transaccion")]
        [Precision(10, 2)]
        public decimal? CantidadTransaccion { get; set; }
        [Column("fecha_transaccion")]
        public DateOnly? FechaTransaccion { get; set; }
        [Column("hora")]
        public TimeOnly? Hora { get; set; }
        [Column("establecimiento")]
        [StringLength(100)]
        public string? Establecimiento { get; set; }
        [Column("ciudad_id")]
        public long? CiudadId { get; set; }
        [Column("tarjeta_id")]
        public int? TarjetaId { get; set; }

        [ForeignKey("CiudadId")]
        [InverseProperty("Transacciones")]
        public virtual Ciudad? Ciudad { get; set; }
        [ForeignKey("TarjetaId")]
        [InverseProperty("Transacciones")]
        public virtual Tarjetum? Tarjeta { get; set; }
        [ForeignKey("TipoTransaccionid")]
        [InverseProperty("Transacciones")]
        public virtual TipoTransaccion? TipoTransaccion { get; set; }
        [InverseProperty("Transaccion")]
        public virtual ICollection<HistorialTransaccione> HistorialTransacciones { get; set; }
    }
}
