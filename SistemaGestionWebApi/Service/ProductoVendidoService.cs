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


        public bool BorrarProductoVendidoPorId(int id)
        {
            ProductoVendido? productoVendido = this.coderContext.ProductoVendidos.Where(p => p.Id == id).FirstOrDefault();

            if (productoVendido is not null)
            {
                this.coderContext.Remove(productoVendido);
                this.coderContext.SaveChanges();
                return true;
            }

            return false;


        }

        public bool ActualizarProductoVendidoPorId(int id, ProductoVendidoDTO productoVendidoDTO)
        {
            ProductoVendido? productoVendido = this.coderContext.ProductoVendidos.Where(p => p.Id == id).FirstOrDefault();

            if (productoVendidoDTO is not null)
            {
                productoVendidoDTO.Stock = productoVendidoDTO.Stock;
                productoVendidoDTO.Id = productoVendidoDTO.Id;
                productoVendidoDTO.IdProducto = productoVendidoDTO.IdProducto;
                productoVendidoDTO.IdVenta = productoVendidoDTO.IdVenta;


                this.coderContext.ProductoVendidos.Update(productoVendido);
                this.coderContext.SaveChanges();
                return true;
            }

            return false;


        }

    }
}
