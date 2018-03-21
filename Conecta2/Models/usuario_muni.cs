namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class usuario_muni
    {
        [Key]
        public int id_usuario_muni { get; set; }

        public int id_usuario { get; set; }

        public int id_muni { get; set; }

        public virtual comi_muni comi_muni { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
