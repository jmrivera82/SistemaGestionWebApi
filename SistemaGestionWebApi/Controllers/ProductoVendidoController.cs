using Microsoft.AspNetCore.Mvc;
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
    }
}
