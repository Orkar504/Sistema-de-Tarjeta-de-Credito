using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("empleado")]
    [Index("CorreoCorporativo", Name = "empleado_correo_corporativo_key", IsUnique = true)]
    [Index("PersonaId", Name = "empleado_persona_id_key", IsUnique = true)]
    public partial class Empleado
    {
        public Empleado()
        {
            Quejas = new HashSet<Queja>();
        }

        [Key]
        [Column("empleado_id")]
        public int EmpleadoId { get; set; }
        [Column("puesto_id")]
        public int PuestoId { get; set; }
        [Column("departamento_bancoid")]
        public int DepartamentoBancoid { get; set; }
        [Column("sucursal_id")]
        public int SucursalId { get; set; }
        [Column("persona_id", TypeName = "character varying")]
        public string PersonaId { get; set; } = null!;
        [Column("correo_corporativo")]
        [StringLength(100)]
        public string CorreoCorporativo { get; set; } = null!;

        [ForeignKey("DepartamentoBancoid")]
        [InverseProperty("Empleados")]
        public virtual DepartamentoBanco DepartamentoBanco { get; set; } = null!;
        [ForeignKey("PersonaId")]
        [InverseProperty("Empleado")]
        public virtual Persona Persona { get; set; } = null!;
        [ForeignKey("SucursalId")]
        [InverseProperty("Empleados")]
        public virtual Sucursal Sucursal { get; set; } = null!;
        [InverseProperty("Empleado")]
        public virtual ICollection<Queja> Quejas { get; set; }
    }
}
