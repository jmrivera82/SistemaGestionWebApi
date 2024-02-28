using Microsoft.AspNetCore.Mvc;
using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Models;
using SistemaGestionWebApi.Service;

namespace SistemaGestionWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : Controller
    {
        private ProductoService productoService;

        public ProductoController(ProductoService productoService)
        {

            this.productoService = productoService;

        }


        [HttpGet]
        public List<Producto> ObtenerListadoDeProductos()
        {
            return this.productoService.ObtenerListadoDeProducto();

        }

        [HttpPost]

        public IActionResult AgregarUnNuevoProducto([FromBody] ProductoDTO producto)
        {

            if (this.productoService.AgregarUnProducto(producto))
            {

                return base.Ok(producto);

            }
            else
            {
                return base.Conflict(new { mensaje = "No se pudo agregar un producto" });

            }

        }


        [HttpDelete("{id}")]

        public IActionResult ActualizarProductoPorId(int id, ProductoDTO productoDTO) 
        { 
            if (id > 0)
            {
                if (this.productoService.ActualizarProductoPorId(id, productoDTO))
                {
                    return base.Ok(new { mensaje = "producto actualizado", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo borrar el producto" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser borrado", status = 400 });

        }

        [HttpPut]

        public IActionResult ActualizarProducto(int id, ProductoDTO productoDTO)
        {
            if (id > 0)
            {
                if (this.productoService.ActualizarProductoPorId(id, productoDTO))
                {
                    return base.Ok(new { mensaje = "producto actualizado", status = 200 });
                }

                else
                {
                    return base.Conflict(new { mensaje = "No se pudo actualizar el producto" });

                }

            }

            return base.BadRequest(new { mensaje = "el id no puede ser actualizado", status = 400 });

        }






    }
}
