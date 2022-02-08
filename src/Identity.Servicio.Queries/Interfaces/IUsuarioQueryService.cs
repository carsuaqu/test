using Identity.Servicio.Queries.DTOs;
using Servicio.Comun.Coleccion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identity.Servicio.Queries.Interfaces
{
    public interface IUsuarioQueryService
    {
        Task<DatosColeccion<UsuarioDto>> GetAllAsync(int page, int take, IEnumerable<string> users = null);
        Task<UsuarioDto> GetAsync(string id);
    }
}
