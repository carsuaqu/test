using Identity.Dominio;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Persistencia.Configuracion
{
    public class RoleConfiguracion
    {
        public RoleConfiguracion(EntityTypeBuilder<ApplicationRole> entityBuilder)
        {
            //entityBuilder.HasKey(x => x.Id);



        }
    }
}
