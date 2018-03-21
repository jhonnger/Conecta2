namespace Conecta2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ContextConecta2 : DbContext
    {
        public ContextConecta2()
            : base("name=ContextConecta2")
        {
        }

        public virtual DbSet<comi_muni> comi_muni { get; set; }
        public virtual DbSet<comi_muni_membresia> comi_muni_membresia { get; set; }
        public virtual DbSet<configuracion> configuracion { get; set; }
        public virtual DbSet<denuncia> denuncia { get; set; }
        public virtual DbSet<estado_denuncia> estado_denuncia { get; set; }
        public virtual DbSet<jurisdiccion> jurisdiccion { get; set; }
        public virtual DbSet<membresia> membresia { get; set; }
        public virtual DbSet<pago> pago { get; set; }
        public virtual DbSet<patrullero> patrullero { get; set; }
        public virtual DbSet<permiso> permiso { get; set; }
        public virtual DbSet<persona> persona { get; set; }
        public virtual DbSet<punto_sector> punto_sector { get; set; }
        public virtual DbSet<rol> rol { get; set; }
        public virtual DbSet<rol_permiso> rol_permiso { get; set; }
        public virtual DbSet<rol_usuario> rol_usuario { get; set; }
        public virtual DbSet<roles> roles { get; set; }
        public virtual DbSet<seccion> seccion { get; set; }
        public virtual DbSet<sub_seccion> sub_seccion { get; set; }
        public virtual DbSet<tipo_denuncia> tipo_denuncia { get; set; }
        public virtual DbSet<tipo_muni> tipo_muni { get; set; }
        public virtual DbSet<ubicacion> ubicacion { get; set; }
        public virtual DbSet<user_claims> user_claims { get; set; }
        public virtual DbSet<user_logins> user_logins { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<usuario> usuario { get; set; }
        public virtual DbSet<usuario_muni> usuario_muni { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<comi_muni>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<comi_muni>()
                .HasMany(e => e.comi_muni_membresia)
                .WithRequired(e => e.comi_muni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comi_muni>()
                .HasMany(e => e.configuracion)
                .WithRequired(e => e.comi_muni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comi_muni>()
                .HasMany(e => e.patrullero)
                .WithRequired(e => e.comi_muni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comi_muni>()
                .HasMany(e => e.usuario_muni)
                .WithRequired(e => e.comi_muni)
                .HasForeignKey(e => e.id_muni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comi_muni_membresia>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<comi_muni_membresia>()
                .HasMany(e => e.pago)
                .WithRequired(e => e.comi_muni_membresia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<configuracion>()
                .Property(e => e.color_primario)
                .IsUnicode(false);

            modelBuilder.Entity<denuncia>()
                .Property(e => e.navegador)
                .IsUnicode(false);

            modelBuilder.Entity<denuncia>()
                .Property(e => e.dispositivo)
                .IsUnicode(false);

            modelBuilder.Entity<denuncia>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<denuncia>()
                .Property(e => e.fec_modificacion)
                .IsUnicode(false);

            modelBuilder.Entity<denuncia>()
                .Property(e => e.fec_creacion)
                .IsUnicode(false);

            modelBuilder.Entity<estado_denuncia>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<estado_denuncia>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<estado_denuncia>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<estado_denuncia>()
                .HasMany(e => e.denuncia)
                .WithRequired(e => e.estado_denuncia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<jurisdiccion>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<jurisdiccion>()
                .HasMany(e => e.comi_muni)
                .WithRequired(e => e.jurisdiccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<jurisdiccion>()
                .HasMany(e => e.punto_sector)
                .WithRequired(e => e.jurisdiccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<jurisdiccion>()
                .HasMany(e => e.seccion)
                .WithRequired(e => e.jurisdiccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<membresia>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<membresia>()
                .Property(e => e.costo)
                .HasPrecision(10, 2);

            modelBuilder.Entity<membresia>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<membresia>()
                .HasMany(e => e.comi_muni_membresia)
                .WithRequired(e => e.membresia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<pago>()
                .Property(e => e.monto)
                .HasPrecision(10, 2);

            modelBuilder.Entity<pago>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<patrullero>()
                .Property(e => e.placa)
                .IsUnicode(false);

            modelBuilder.Entity<permiso>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<permiso>()
                .HasMany(e => e.rol_permiso)
                .WithRequired(e => e.permiso)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<persona>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<persona>()
                .Property(e => e.apellido)
                .IsUnicode(false);

            modelBuilder.Entity<persona>()
                .Property(e => e.num_doc)
                .IsUnicode(false);

            modelBuilder.Entity<persona>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<persona>()
                .HasMany(e => e.patrullero)
                .WithRequired(e => e.persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<persona>()
                .HasMany(e => e.usuario)
                .WithRequired(e => e.persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<punto_sector>()
                .Property(e => e.longitud)
                .HasPrecision(10, 6);

            modelBuilder.Entity<punto_sector>()
                .Property(e => e.latitud)
                .HasPrecision(10, 6);

            modelBuilder.Entity<rol>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<rol>()
                .HasMany(e => e.rol_permiso)
                .WithRequired(e => e.rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rol>()
                .HasMany(e => e.rol_usuario)
                .WithRequired(e => e.rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<rol_usuario>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<roles>()
                .HasMany(e => e.users)
                .WithMany(e => e.roles)
                .Map(m => m.ToTable("user_roles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<seccion>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<seccion>()
                .HasMany(e => e.sub_seccion)
                .WithRequired(e => e.seccion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sub_seccion>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_denuncia>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_denuncia>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_denuncia>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_denuncia>()
                .HasMany(e => e.denuncia)
                .WithRequired(e => e.tipo_denuncia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tipo_muni>()
                .Property(e => e.nombre)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_muni>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<tipo_muni>()
                .HasMany(e => e.comi_muni)
                .WithRequired(e => e.tipo_muni)
                .HasForeignKey(e => e.id_tipo_comi_muni)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ubicacion>()
                .Property(e => e.latitud)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ubicacion>()
                .Property(e => e.longitud)
                .HasPrecision(10, 6);

            modelBuilder.Entity<ubicacion>()
                .Property(e => e.descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<ubicacion>()
                .HasMany(e => e.denuncia)
                .WithRequired(e => e.ubicacion)
                .HasForeignKey(e => e.id_posicion_denuncia)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ubicacion>()
                .HasMany(e => e.denuncia1)
                .WithRequired(e => e.ubicacion1)
                .HasForeignKey(e => e.id_posicion_usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<users>()
                .HasMany(e => e.user_claims)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<users>()
                .HasMany(e => e.user_logins)
                .WithRequired(e => e.users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<usuario>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.foto_perfil)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .Property(e => e.usuario_mod)
                .IsUnicode(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.denuncia)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.rol_usuario)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<usuario>()
                .HasMany(e => e.usuario_muni)
                .WithRequired(e => e.usuario)
                .WillCascadeOnDelete(false);
        }
    }
}
