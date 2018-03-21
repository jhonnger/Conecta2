namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class punto_sector
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_punto_jurisdiccion { get; set; }

        public int id_jurisdiccion { get; set; }

        public decimal longitud { get; set; }

        public decimal latitud { get; set; }

        public int orden { get; set; }

        public virtual jurisdiccion jurisdiccion { get; set; }
    }
}
