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

        public bool BorrarProductoPorId(int id)
        {
            Producto? producto = this.coderContext.Productos.Where(p=> p.Id == id).FirstOrDefault();    

            if (producto is not null)
            {
                this.coderContext.Remove(producto);
                this.coderContext.SaveChanges() ;
                return true;
            }

            return false;   


        }

        public bool ActualizarProductoPorId(int id, ProductoDTO productoDTO)
        {
            Producto? producto = this.coderContext.Productos.Where(p => p.Id == id).FirstOrDefault();

            if (producto is not null)
            {
                producto.PrecioVenta = productoDTO.PrecioVenta;
                producto.Stock = productoDTO.Stock;
                producto.Descripciones = productoDTO.Descripciones;

                producto.IdUsuario = productoDTO.IdUsuario;
 
                producto.Costo = productoDTO.Costo;

                this.coderContext.Productos.Update(producto);
                this.coderContext.SaveChanges();
                return true;
            }

            return false;


        }


    }
}
