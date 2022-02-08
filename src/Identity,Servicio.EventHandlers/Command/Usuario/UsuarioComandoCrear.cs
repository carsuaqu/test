using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Servicio.EventHandlers.Command.Usuario
{
    public  class UsuarioComandoCrear : IRequest<IdentityResult>
    {
       
        public string UserName { get; set; }
        
        public string NormalizedUserName { get; set; }
       
        public string Email { get; set; }
        
        public string Password { get; set; }
    }
}
