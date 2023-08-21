using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("cliente")]
    public partial class Cliente
    {
        public Cliente()
        {
            Cuenta = new HashSet<Cuentum>();
            EstadoCuenta = new HashSet<EstadoCuentum>();
            Moras = new HashSet<Mora>();
            PagoCreditos = new HashSet<PagoCredito>();
            Quejas = new HashSet<Queja>();
            Tarjeta = new HashSet<Tarjetum>();
        }

        [Key]
        [Column("cliente_id")]
        public int ClienteId { get; set; }
        [Column("persona_id", TypeName = "character varying")]
        public string? PersonaId { get; set; }
        [Column("datos_laborales_id")]
        public long DatosLaboralesId { get; set; }

        [ForeignKey("DatosLaboralesId")]
        [InverseProperty("Clientes")]
        public virtual DatosLaborale DatosLaborales { get; set; } = null!;
        [ForeignKey("PersonaId")]
        [InverseProperty("Clientes")]
        public virtual Persona? Persona { get; set; }
        [InverseProperty("Cliente")]
        public virtual ICollection<Cuentum> Cuenta { get; set; }
        [InverseProperty("Cliente")]
        public virtual ICollection<EstadoCuentum> EstadoCuenta { get; set; }
        [InverseProperty("Cliente")]
        public virtual ICollection<Mora> Moras { get; set; }
        [InverseProperty("Cliente")]
        public virtual ICollection<PagoCredito> PagoCreditos { get; set; }
        [InverseProperty("Cliente")]
        public virtual ICollection<Queja> Quejas { get; set; }
        [InverseProperty("Cliente")]
        public virtual ICollection<Tarjetum> Tarjeta { get; set; }
    }
}
