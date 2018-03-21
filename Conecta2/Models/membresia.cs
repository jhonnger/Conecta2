namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("membresia")]
    public partial class membresia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public membresia()
        {
            comi_muni_membresia = new HashSet<comi_muni_membresia>();
        }

        [Key]
        public int id_membresia { get; set; }

        [Required]
        [StringLength(50)]
        public string descripcion { get; set; }

        public int cant_usuarios { get; set; }

        public int dias_duracion { get; set; }

        public decimal costo { get; set; }

        public int limite_reportes_dia { get; set; }

        public int limite_usuarios { get; set; }

        public DateTime fec_creacion { get; set; }

        public DateTime fec_modificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario_mod { get; set; }

        public bool estado { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comi_muni_membresia> comi_muni_membresia { get; set; }
    }
}
