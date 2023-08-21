using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Tarjeta_de_Credito.Models
{
    [Table("tipo_transaccion")]
    public partial class TipoTransaccion
    {
        public TipoTransaccion()
        {
            Transacciones = new HashSet<Transaccione>();
        }

        [Key]
        [Column("tipo_transaccionid")]
        public int TipoTransaccionid { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string? Nombre { get; set; }

        [InverseProperty("TipoTransaccion")]
        public virtual ICollection<Transaccione> Transacciones { get; set; }
    }
}
