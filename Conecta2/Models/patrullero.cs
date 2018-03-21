namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("patrullero")]
    public partial class patrullero
    {
        [Key]
        public int id_patrullero { get; set; }

        [Required]
        [StringLength(10)]
        public string placa { get; set; }

        public int id_persona { get; set; }

        public int id_comi_muni { get; set; }

        public virtual comi_muni comi_muni { get; set; }

        public virtual persona persona { get; set; }
    }
}
