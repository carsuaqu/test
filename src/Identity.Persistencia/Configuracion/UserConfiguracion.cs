using Identity.Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Persistencia.Configuracion
{
   public  class UserConfiguracion
    {
        public UserConfiguracion(EntityTypeBuilder<ApplicationUser> entityBuilder)
        {


            entityBuilder.Property(x => x.UserName).HasColumnName("Usuario").IsRequired().HasMaxLength(100);

        }
    }
}
