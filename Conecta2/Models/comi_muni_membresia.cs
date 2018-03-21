namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comi_muni_membresia
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comi_muni_membresia()
        {
            pago = new HashSet<pago>();
        }

        [Key]
        public int id_comi_muni_membresia { get; set; }

        public int id_membresia { get; set; }

        public int id_comi_muni { get; set; }

        public int cant_meses { get; set; }

        public DateTime fec_creacion { get; set; }

        public DateTime fec_modificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario_mod { get; set; }

        public bool estado { get; set; }

        public virtual comi_muni comi_muni { get; set; }

        public virtual membresia membresia { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<pago> pago { get; set; }
    }
}
