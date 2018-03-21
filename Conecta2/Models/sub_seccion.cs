namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sub_seccion
    {
        [Key]
        public int id_sub_seccion { get; set; }

        [Required]
        [StringLength(100)]
        public string descripcion { get; set; }

        public int id_seccion { get; set; }

        public virtual seccion seccion { get; set; }
    }
}
