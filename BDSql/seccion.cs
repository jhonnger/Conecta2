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
    
    public partial class seccion
    {
        public int id_seccion { get; set; }
        public string descripcion { get; set; }
        public int id_jurisdiccion { get; set; }
    
        public virtual jurisdiccion jurisdiccion { get; set; }
    }
}
