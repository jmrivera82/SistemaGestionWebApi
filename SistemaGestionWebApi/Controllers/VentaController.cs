using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.Models;
using SistemaGestionWebApi.Service;

namespace SistemaGestionWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class VentaController : Controller
    {
        private VentaService ventaService;

        public VentaController(VentaService ventaService)
        {

            this.ventaService = ventaService;

        }


        [HttpGet]
        public List<Ventum> ObtenerListadoDeVentas()
        {
            return this.ventaService.ObtenerListadoDeVenta();

        }
    }
}
