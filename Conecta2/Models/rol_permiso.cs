namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class rol_permiso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_rol_permiso { get; set; }

        public int id_rol { get; set; }

        public int id_permiso { get; set; }

        public virtual permiso permiso { get; set; }

        public virtual rol rol { get; set; }
    }
}
