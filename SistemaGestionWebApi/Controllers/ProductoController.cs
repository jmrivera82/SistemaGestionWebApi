using Microsoft.AspNetCore.Mvc;
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

    }
}
