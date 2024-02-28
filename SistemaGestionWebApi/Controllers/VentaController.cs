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


        [HttpDelete("{id}")]

        public IActionResult BorrarVenta(int id)
        {
            if (id > 0)
            {
                if (this.ventaService.BorrarVentaPorId(id))
                {
                    return base.Ok(new { mensaje = "venta borrada", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo borrar la venta" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser borrado", status = 400 });

        }

        [HttpPut]
        public IActionResult ActualizarVenta(int id, VentaDTO ventaDTO)
        {
            if (id > 0)
            {
                if (this.ventaService.ActualizarVentaPorId(id, ventaDTO))
                {
                    return base.Ok(new { mensaje = "venta actualizado", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo actualizar la venta" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser actualizado", status = 400 });

        }

    }
}
