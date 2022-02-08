using Identity.Dominio;
using Identity.Servicio.EventHandlers.Responses;
using Identity.Servicio.EventHandlers.Command.Usuario;
using MediatR;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Servicio.EventHandlers.Handlers
{
    public class UsuarioEventHandler :IRequestHandler<UsuarioComandoCrear, IdentityResult>
    {
        private readonly UserManager<ApplicationUser> _userManager;
        public UsuarioEventHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }



        public async Task<IdentityResult> Handle(UsuarioComandoCrear request, CancellationToken cancellationToken)
        {




            var entry = new ApplicationUser
            {
                UserName = request.UserName,
                NormalizedUserName = request.NormalizedUserName,
                Email = request.Email,
                
            };

            return await _userManager.CreateAsync(entry, request.Password);
        }
    }
}
