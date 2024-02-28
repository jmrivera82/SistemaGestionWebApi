using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Models;
using SistemaGestionWebApi.Service;

namespace SistemaGestionWebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductoVendidoController : Controller
    {
        private ProductoVendidoService productoVendidoService;

        public ProductoVendidoController(ProductoVendidoService productoVendidoService)
        {

            this.productoVendidoService = productoVendidoService;

        }


        [HttpGet]
        public List<ProductoVendido> ObtenerListadoDeProductosVendidos()
        {
            return this.productoVendidoService.ObtenerListadoDeProductoVendido();

        }


        [HttpPost]

        public IActionResult AgregarUnNuevoProductoVendido([FromBody] ProductoVendidoDTO productoVendido)
        {

            if (this.productoVendidoService.AgregarUnProductoVendido(productoVendido))
            {

                return base.Ok(productoVendido);

            }
            else
            {
                return base.Conflict(new { mensaje = "No se pudo agregar un producto vendido" });

            }



        }

        [HttpDelete("{id}")]

        public IActionResult BorrarProductoVendido(int id)
        {
            if (id > 0)
            {
                if (this.productoVendidoService.BorrarProductoVendidoPorId(id))
                {
                    return base.Ok(new { mensaje = "producto vendido borrado", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo borrar el producto" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser borrado", status = 400 });

        }

        [HttpPut]

        public IActionResult ActualizarProductoVendido(int id, ProductoVendidoDTO productoVendidoDTO)
        {
            if (id > 0)
            {
                if (this.productoVendidoService.ActualizarProductoVendidoPorId(id, productoVendidoDTO))
                {
                    return base.Ok(new { mensaje = "producto vendido actualizado", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo actualizar el producto vendido" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser actualizado", status = 400 });

        }

    }
}
