namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("pago")]
    public partial class pago
    {
        [Key]
        public int id_pago { get; set; }

        public int id_comi_muni_membresia { get; set; }

        public decimal monto { get; set; }

        [Required]
        [MaxLength(50)]
        public byte[] cod_transaccion { get; set; }

        public DateTime fec_modificacion { get; set; }

        public DateTime fec_creacion { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario_mod { get; set; }

        public virtual comi_muni_membresia comi_muni_membresia { get; set; }
    }
}
