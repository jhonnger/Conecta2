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
    using System.ComponentModel.DataAnnotations;

    public partial class patrullero
    {
        [Key]
        public int id_patrullero { get; set; }
        public string placa { get; set; }
        public int id_persona { get; set; }
        public int id_comi_muni { get; set; }
    
        public virtual comi_muni comi_muni { get; set; }
        public virtual persona persona { get; set; }
    }
}
