using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.DTOs;
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

        [HttpPost]

        public IActionResult AgregarUnNuevoUsuario([FromBody] UsuarioDTO usuario)
        {

            if (this.usuarioService.AgregarUnUsuario(usuario))
            {

                return base.Ok(usuario);

            }
            else
            {
                return base.Conflict(new { mensaje = "No se pudo agregar un producto" });

            }

        }


        [HttpDelete("{id}")]

        public IActionResult BorrarUsuario(int id)
        {
            if (id > 0)
            {
                if (this.usuarioService.BorrarUsuarioPorId(id))
                {
                    return base.Ok(new { mensaje = "usuario borrado", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo borrar el usuario" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser borrado", status = 400 });

        }

        [HttpPut]
        public IActionResult ActualizarUsuario(int id, UsuarioDTO usuarioDTO)
        {
            if (id > 0)
            {
                if (this.usuarioService.ActualizarUsuarioPorId(id, usuarioDTO))
                {
                    return base.Ok(new { mensaje = "usuario actualizado", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo actualizar el usuario" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser actualizado", status = 400 });

        }


    }
}
