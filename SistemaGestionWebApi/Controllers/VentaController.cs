using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.DTOs;
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


        [HttpPost]

        public IActionResult AgregarUnaNuevaVenta([FromBody] VentaDTO venta)
        {

            if (this.ventaService.AgregarUnaVenta(venta))
            {

                return base.Ok(venta);

            }
            else
            {
                return base.Conflict(new { mensaje = "No se pudo agregar una venta" });

            }

        }


    }
}
