using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class ProductoVendidoService
    {

        private CoderContext context;

        public ProductoVendidoService(CoderContext coderContext)

        {
            this.context = coderContext;
        }



        public List<ProductoVendido> ObtenerListadoDeProductoVendido()
        {
            return this.context.ProductoVendidos.ToList();
        }
    }
}
