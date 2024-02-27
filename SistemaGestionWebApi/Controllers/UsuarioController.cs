using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.Models;
using SistemaGestionWebApi.Service;

namespace SistemaGestionWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : Controller
    {

        private UsuarioService usuarioService;

        public UsuarioController(UsuarioService usuarioService) {
            
            this.usuarioService = usuarioService;
        
        }


        [HttpGet]
        public List<Usuario> ObtenerListadoDeUsuarios()
        {
            return this.usuarioService.ObtenerListadoDeUsuario();

        }
 
    }
}
