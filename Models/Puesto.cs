using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("puesto")]
    public partial class Puesto
    {
        [Key]
        [Column("puesto_id")]
        public int PuestoId { get; set; }
        [Column("nombre_puesto")]
        [StringLength(50)]
        public string? NombrePuesto { get; set; }
    }
}
