using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Mapper;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class ProductoService
    {

        private CoderContext coderContext;

        public ProductoService(CoderContext coderContext)

        {
            this.coderContext = coderContext;
        }



        public List<Producto> ObtenerListadoDeProducto()
        {
            return this.coderContext.Productos.ToList();
        }


        public bool AgregarUnProducto (ProductoDTO dto)
        {

            Producto p = ProductoMapper.MapearAProducto(dto);

            
            this.coderContext.Productos.Add(p);
            this.coderContext.SaveChanges();
            return true;    
        }


    }
}
