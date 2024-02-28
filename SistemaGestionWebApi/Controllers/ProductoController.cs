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

        public IActionResult AgregarUnNuevoProducto([FromBody]ProductoDTO producto)
        {

            if (this.productoService.AgregarUnProducto(producto))
            {

            return base.Ok(producto);

            }
            else
            {
                return base.Conflict(new { mensaje="No se pudo agregar un producto"});

            }

        }






    }
}
