using Microsoft.AspNetCore.Mvc;

namespace SistemaGestionWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]

    public class NombreController : Controller
    { 
        List<string> list;

        public NombreController() { 
            this.list = new List<string>() { "Alejandro", "pepe", "lulu" };
        }
        
   
        [HttpGet("Listado")]
        public List<string> ObtenerListadoDeNombres()
        {
            return this.list;

        }

        [HttpGet("Listado/{id}")]
        public ActionResult <string> ObtenerNombrePorId(int id)
        {

            if (id <0 || id>= list.Count)
            {
                return BadRequest(new { mensaje = $"El numero no puede ser negativo o mayor que {this.list.Count}", status = 400 });
            }
            return this.list[id];

        }



    }
}
