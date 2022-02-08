using Identity.Persistencia;
using Identity.Servicio.Queries.DTOs;
using Identity.Servicio.Queries.Interfaces;
using Microsoft.EntityFrameworkCore;
using Servicio.Comun.Coleccion;
using Servicio.Comun.Mapeo;
using Servicio.Comun.Paginacion;

namespace Identity.Servicio.Queries
{

    public class UsuarioQueryService : IUsuarioQueryService
    {
        private readonly ApplicationDbContext _context;

        public UsuarioQueryService(
            ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<DatosColeccion<UsuarioDto>> GetAllAsync(int page, int take, IEnumerable<string> users = null)
        {
            var collection = await _context.Users
                .Where(x => users == null || users.Contains(x.Id))
                .GetPagedAsync(page, take);

            return collection.MapTo<DatosColeccion<UsuarioDto>>();
        }

        public async Task<UsuarioDto> GetAsync(string id)
        {
            return (await _context.Users.SingleAsync(x => x.Id == id)).MapTo<UsuarioDto>();
        }
    }
}
