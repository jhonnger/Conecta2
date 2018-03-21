namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class comi_muni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comi_muni()
        {
            comi_muni_membresia = new HashSet<comi_muni_membresia>();
            configuracion = new HashSet<configuracion>();
            patrullero = new HashSet<patrullero>();
            usuario_muni = new HashSet<usuario_muni>();
        }

        [Key]
        public int id_comi_muni { get; set; }

        public int id_tipo_comi_muni { get; set; }

        public int id_jurisdiccion { get; set; }

        public int id_ubicacion { get; set; }

        public int id_membresia { get; set; }

        public DateTime fec_creacion { get; set; }

        public DateTime fec_modificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario_mod { get; set; }

        public bool estado { get; set; }

        public virtual jurisdiccion jurisdiccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comi_muni_membresia> comi_muni_membresia { get; set; }

        public virtual tipo_muni tipo_muni { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<configuracion> configuracion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patrullero> patrullero { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<usuario_muni> usuario_muni { get; set; }
    }
}
