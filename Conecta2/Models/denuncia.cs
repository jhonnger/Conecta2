namespace Conecta2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("denuncia")]
    public partial class denuncia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_denuncia { get; set; }

        public int id_tipo_denuncia { get; set; }

        public int id_usuario { get; set; }

        public int id_estado_denuncia { get; set; }

        public int id_posicion_denuncia { get; set; }

        public int id_posicion_usuario { get; set; }

        public int descripcion { get; set; }

        public DateTime fec_denuncia { get; set; }

        [Required]
        [StringLength(50)]
        public string navegador { get; set; }

        [Required]
        [StringLength(50)]
        public string dispositivo { get; set; }

        [Required]
        [StringLength(50)]
        public string usuario_mod { get; set; }

        [Required]
        [StringLength(50)]
        public string fec_modificacion { get; set; }

        [Required]
        [StringLength(50)]
        public string fec_creacion { get; set; }

        public bool estado { get; set; }

        public virtual estado_denuncia estado_denuncia { get; set; }

        public virtual tipo_denuncia tipo_denuncia { get; set; }

        public virtual ubicacion ubicacion { get; set; }

        public virtual ubicacion ubicacion1 { get; set; }

        public virtual usuario usuario { get; set; }
    }
}
