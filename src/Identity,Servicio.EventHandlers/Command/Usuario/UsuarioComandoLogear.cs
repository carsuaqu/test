using Identity.Servicio.EventHandlers.Responses;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Identity.Servicio.EventHandlers.Command.Usuario
{
    public class UsuarioComandoLogear : IRequest<IdentityAccess>
    {
        [Required, EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
