namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rol_usuario
    {
        [Key]
        public int id_rol_usuario { get; set; }

        [Required]
        [StringLength(60)]
        public string descripcion { get; set; }

        public int id_rol { get; set; }

        public int id_usuario { get; set; }

        public virtual rol rol { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
