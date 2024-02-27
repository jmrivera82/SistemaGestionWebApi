using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class ProductoService
    {

        private CoderContext context;

        public ProductoService(CoderContext coderContext)

        {
            this.context = coderContext;
        }



        public List<Producto> ObtenerListadoDeProducto()
        {
            return this.context.Productos.ToList();
        }


    }
}
