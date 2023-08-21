using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("departamento_banco")]
    public partial class DepartamentoBanco
    {
        public DepartamentoBanco()
        {
            Empleados = new HashSet<Empleado>();
        }

        [Key]
        [Column("departamento_bancoid")]
        public int DepartamentoBancoid { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string? Nombre { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string? Descripcion { get; set; }

        [InverseProperty("DepartamentoBanco")]
        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
