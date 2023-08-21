using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("persona")]
    public partial class Persona
    {
        public Persona()
        {
            Clientes = new HashSet<Cliente>();
            ReferenciaPersonals = new HashSet<ReferenciaPersonal>();
            SolicitudTarjeta = new HashSet<SolicitudTarjetum>();
            Telefonos = new HashSet<Telefono>();
        }

        [Key]
        [Column("persona_id")]
        [StringLength(20)]
        public string PersonaId { get; set; } = null!;
        [Column("p_nombre")]
        [StringLength(30)]
        public string PNombre { get; set; } = null!;
        [Column("s_nombre")]
        [StringLength(30)]
        public string? SNombre { get; set; }
        [Column("p_apellido")]
        [StringLength(30)]
        public string PApellido { get; set; } = null!;
        [Column("s_apellido")]
        [StringLength(30)]
        public string? SApellido { get; set; }
        [Column("correo")]
        [StringLength(50)]
        public string? Correo { get; set; }
        [Column("fecha_nacimiento")]
        public DateOnly? FechaNacimiento { get; set; }
        [Column("direccion_id")]
        public long DireccionId { get; set; }
        [Column("tipo_personaid")]
        public int TipoPersonaid { get; set; }
        [Column("tipo_documentoid")]
        public int TipoDocumentoid { get; set; }

        [ForeignKey("DireccionId")]
        [InverseProperty("Personas")]
        public virtual Direccion Direccion { get; set; } = null!;
        [ForeignKey("TipoDocumentoid")]
        [InverseProperty("Personas")]
        public virtual TipoDocumento TipoDocumento { get; set; } = null!;
        [ForeignKey("TipoPersonaid")]
        [InverseProperty("Personas")]
        public virtual TipoPersona TipoPersona { get; set; } = null!;
        [InverseProperty("Persona")]
        public virtual Empleado? Empleado { get; set; }
        [InverseProperty("Persona")]
        public virtual ICollection<Cliente> Clientes { get; set; }
        [InverseProperty("Persona")]
        public virtual ICollection<ReferenciaPersonal> ReferenciaPersonals { get; set; }
        [InverseProperty("Persona")]
        public virtual ICollection<SolicitudTarjetum> SolicitudTarjeta { get; set; }
        [InverseProperty("Persona")]
        public virtual ICollection<Telefono> Telefonos { get; set; }
    }
}
