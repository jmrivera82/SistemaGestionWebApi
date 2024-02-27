using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class VentaService
    {

        private CoderContext context;

        public VentaService(CoderContext coderContext)

        {
            this.context = coderContext;
        }



        public List<Ventum> ObtenerListadoDeVenta()
        {
            return this.context.Venta.ToList();
        }


    }
}
