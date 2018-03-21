namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("configuracion")]
    public partial class configuracion
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_configuracion { get; set; }

        [Required]
        [StringLength(7)]
        public string color_primario { get; set; }

        public int campos_reporte { get; set; }

        public int id_comi_muni { get; set; }

        public virtual comi_muni comi_muni { get; set; }
    }
}
