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
    
    public partial class denuncia
    {
        public int id_denuncia { get; set; }
        public int id_tipo_denuncia { get; set; }
        public int id_usuario { get; set; }
        public int id_estado_denuncia { get; set; }
        public int id_posicion_denuncia { get; set; }
        public int id_posicion_usuario { get; set; }
        public int descripcion { get; set; }
        public System.DateTime fec_denuncia { get; set; }
        public string navegador { get; set; }
        public string dispositivo { get; set; }
        public string usuario_mod { get; set; }
        public string fec_modificacion { get; set; }
        public string fec_creacion { get; set; }
        public bool estado { get; set; }
    
        public virtual estado_denuncia estado_denuncia { get; set; }
        public virtual tipo_denuncia tipo_denuncia { get; set; }
        public virtual ubicacion ubicacion { get; set; }
        public virtual ubicacion ubicacion1 { get; set; }
        public virtual usuario usuario { get; set; }
    }
}
