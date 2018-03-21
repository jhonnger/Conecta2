using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Conecta2.Models
{
    public class MyUser : IdentityUser<long, MyLogin, MyUserRole, MyClaim>

    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<MyUser, long> manager)
        {
            // Tenga en cuenta que el valor de authenticationType debe coincidir con el definido en CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Agregar aquí notificaciones personalizadas de usuario
            return userIdentity;
        }

       
    }

    public class MyClaim : IdentityUserClaim<long>
    {
    }

    public class MyUserRole: IdentityUserRole<long>
    {
    }

    public class MyRole: IdentityRole<long, MyUserRole>
    {
    }

    public class MyLogin: IdentityUserLogin<long>
    {
    }

    public class ApplicationDBContext : IdentityDbContext<MyUser, MyRole, long, MyLogin, MyUserRole, MyClaim>
    {
        public ApplicationDBContext()
            : base("ContextConecta2") { }

        public static ApplicationDBContext Create()
        {
            return new ApplicationDBContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<MyUser>().ToTable("users");
            modelBuilder.Entity<MyUserRole>().ToTable("user_roles");
            modelBuilder.Entity<MyRole>().ToTable("roles");
            modelBuilder.Entity<MyClaim>().ToTable("user_claims");
            modelBuilder.Entity<MyLogin>().ToTable("user_logins");

            modelBuilder.Entity<MyUser>().Property( r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MyRole>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            modelBuilder.Entity<MyClaim>().Property(r => r.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        }
    }
}