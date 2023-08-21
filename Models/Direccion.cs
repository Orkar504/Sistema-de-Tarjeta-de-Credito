using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("direccion")]
    public partial class Direccion
    {
        public Direccion()
        {
            Personas = new HashSet<Persona>();
            SolicitudTarjeta = new HashSet<SolicitudTarjetum>();
            Sucursals = new HashSet<Sucursal>();
        }

        [Column("departamentoid")]
        public int Departamentoid { get; set; }
        [Column("cuidadid")]
        public long Cuidadid { get; set; }
        [Column("municipioid")]
        public long Municipioid { get; set; }
        [Column("calle")]
        [StringLength(50)]
        public string? Calle { get; set; }
        [Column("avenida")]
        [StringLength(50)]
        public string? Avenida { get; set; }
        [Column("referencia_geografica")]
        [StringLength(50)]
        public string? ReferenciaGeografica { get; set; }
        [Column("numero_casa_apartameto")]
        public int? NumeroCasaApartameto { get; set; }
        [Column("paisid")]
        public int Paisid { get; set; }
        [Key]
        [Column("direccion_id")]
        public long DireccionId { get; set; }

        [ForeignKey("Cuidadid")]
        [InverseProperty("Direccions")]
        public virtual Ciudad Cuidad { get; set; } = null!;
        [ForeignKey("Departamentoid")]
        [InverseProperty("Direccions")]
        public virtual Departamento Departamento { get; set; } = null!;
        [ForeignKey("Municipioid")]
        [InverseProperty("Direccions")]
        public virtual Municipio Municipio { get; set; } = null!;
        [ForeignKey("Paisid")]
        [InverseProperty("Direccions")]
        public virtual Pai Pais { get; set; } = null!;
        [InverseProperty("Direccion")]
        public virtual ICollection<Persona> Personas { get; set; }
        [InverseProperty("Direccion")]
        public virtual ICollection<SolicitudTarjetum> SolicitudTarjeta { get; set; }
        [InverseProperty("Direccion")]
        public virtual ICollection<Sucursal> Sucursals { get; set; }
    }
}
