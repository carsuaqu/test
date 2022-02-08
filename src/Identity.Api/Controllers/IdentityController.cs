using Identity.Dominio;
using Identity.Servicio.EventHandlers.Command.Usuario;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IdentityController : ControllerBase
    {
        private readonly ILogger<IdentityController> _logger;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMediator _mediator;

        public IdentityController(ILogger<IdentityController> logger,
            SignInManager<ApplicationUser> signInManager,
            IMediator mediator)
        {
            _logger = logger;
            _signInManager = signInManager;
            _mediator = mediator;

        }

        [HttpPost]
        public async Task<IActionResult> Create(UsuarioComandoCrear command)
        {
            if (ModelState.IsValid)
            {
                var result = await _mediator.Send(command);

                if (!result.Succeeded)
                {
                    return BadRequest(result.Errors);
                }

                return Ok();
            }

            return BadRequest();
        }
    }
}
