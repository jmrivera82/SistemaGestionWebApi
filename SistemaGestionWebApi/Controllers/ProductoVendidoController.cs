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
    }
}
