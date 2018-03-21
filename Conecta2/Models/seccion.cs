namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("seccion")]
    public partial class seccion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public seccion()
        {
            sub_seccion = new HashSet<sub_seccion>();
        }

        [Key]
        public int id_seccion { get; set; }

        [Required]
        [StringLength(100)]
        public string descripcion { get; set; }

        public int id_jurisdiccion { get; set; }

        public virtual jurisdiccion jurisdiccion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<sub_seccion> sub_seccion { get; set; }
    }
}
