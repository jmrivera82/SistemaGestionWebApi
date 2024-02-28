using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Mapper;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class ProductoVendidoService
    {

        private CoderContext coderContext;

        public ProductoVendidoService(CoderContext coderContext)

        {
            this.coderContext = coderContext;
        }



        public List<ProductoVendido> ObtenerListadoDeProductoVendido()
        {
            return this.coderContext.ProductoVendidos.ToList();
        }

        public bool AgregarUnProductoVendido(ProductoVendidoDTO dto)
        {

            ProductoVendido p = ProductoVendidoMapper.MapearAProductoVendido(dto);


            this.coderContext.ProductoVendidos.Add(p);
            this.coderContext.SaveChanges();
            return true;
        }
    }
}
