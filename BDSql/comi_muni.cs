//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BDSql
{
    using System;
    using System.Collections.Generic;
    
    public partial class comi_muni
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public comi_muni()
        {
            this.comi_muni_membresia = new HashSet<comi_muni_membresia>();
            this.configuracion = new HashSet<configuracion>();
            this.patrullero = new HashSet<patrullero>();
        }
    
        public int id_comi_muni { get; set; }
        public int id_tipo_comi_muni { get; set; }
        public int id_responsable { get; set; }
        public int id_jurisdiccion { get; set; }
        public int id_ubicacion { get; set; }
        public int id_membresia { get; set; }
        public System.DateTime fec_creacion { get; set; }
        public System.DateTime fec_modificacion { get; set; }
        public string usuario_mod { get; set; }
        public bool estado { get; set; }
    
        public virtual jurisdiccion jurisdiccion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<comi_muni_membresia> comi_muni_membresia { get; set; }
        public virtual persona persona { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<configuracion> configuracion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patrullero> patrullero { get; set; }
    }
}
