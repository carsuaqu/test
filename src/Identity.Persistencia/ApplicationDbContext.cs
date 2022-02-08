using Identity.Dominio;
using Identity.Persistencia.Configuracion;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace Identity.Persistencia
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options
        )
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);



            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>().ToTable("Usuarios");
            builder.Entity<ApplicationRole>().ToTable("Perfiles");
            builder.Entity<IdentityUserClaim<string>>().ToTable("Usuarios_Claims");
            builder.Entity<IdentityUserLogin<string>>().ToTable("Usuarios_Logins");
            builder.Entity<IdentityUserRole<string>>().ToTable("Usuarios_Perfiles");
            builder.Entity<IdentityRoleClaim<string>>().ToTable("Perfiles_Claims");
            builder.Entity<IdentityUserToken<string>>().ToTable("Usuarios_Tokens");

            // Database schema
            builder.HasDefaultSchema("Seg");

            // Model Contraints
            ModelConfig(builder);



        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
            new UserConfiguracion(modelBuilder.Entity<ApplicationUser>());
            // new RoleConfiguracion(modelBuilder.Entity<ApplicationRole>());
        }

    }
}
