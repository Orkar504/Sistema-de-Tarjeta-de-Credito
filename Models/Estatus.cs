using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("Estatus")]
    public partial class Estatus
    {
        public Estatus()
        {
            Moras = new HashSet<Mora>();
        }

        [Key]
        [Column("Estatus_id")]
        public int EstatusId { get; set; }
        [Column("Estatus")]
        public bool? Estatus1 { get; set; }

        [InverseProperty("Estatus")]
        public virtual ICollection<Mora> Moras { get; set; }
    }
}
