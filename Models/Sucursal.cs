using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("sucursal")]
    public partial class Sucursal
    {
        public Sucursal()
        {
            Empleados = new HashSet<Empleado>();
            SolicitudTarjeta = new HashSet<SolicitudTarjetum>();
            Tarjeta = new HashSet<Tarjetum>();
            Telefonosucursals = new HashSet<Telefonosucursal>();
        }

        [Key]
        [Column("sucursal_id")]
        public int SucursalId { get; set; }
        [Column("direccion_id")]
        public long? DireccionId { get; set; }
        [Column("nombre_sucursal")]
        [StringLength(50)]
        public string? NombreSucursal { get; set; }

        [ForeignKey("DireccionId")]
        [InverseProperty("Sucursals")]
        public virtual Direccion? Direccion { get; set; }
        [InverseProperty("Sucursal")]
        public virtual ICollection<Empleado> Empleados { get; set; }
        [InverseProperty("Sucursal")]
        public virtual ICollection<SolicitudTarjetum> SolicitudTarjeta { get; set; }
        [InverseProperty("Sucursal")]
        public virtual ICollection<Tarjetum> Tarjeta { get; set; }
        [InverseProperty("Sucursal")]
        public virtual ICollection<Telefonosucursal> Telefonosucursals { get; set; }
    }
}
