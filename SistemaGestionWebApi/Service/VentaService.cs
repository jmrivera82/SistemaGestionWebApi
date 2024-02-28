using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Mapper;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class VentaService
    {

        private CoderContext coderContext;

        public VentaService(CoderContext coderContext)

        {
            this.coderContext = coderContext;
        }



        public List<Ventum> ObtenerListadoDeVenta()
        {
            return this.coderContext.Venta.ToList();
        }

        public bool AgregarUnaVenta(VentaDTO dto)
        {

            Ventum p = VentaMapper.MapearAVenta(dto);


            this.coderContext.Venta.Add(p);
            this.coderContext.SaveChanges();
            return true;
        }

        public bool BorrarVentaPorId(int id)
        {
            Ventum? venta = this.coderContext.Venta.Where(p => p.Id == id).FirstOrDefault();

            if (venta is not null)
            {
                this.coderContext.Remove(venta);
                this.coderContext.SaveChanges();
                return true;
            }

            return false;


        }

        public bool ActualizarVentaPorId(int id, VentaDTO ventaDTO)
        {
            Ventum? venta = this.coderContext.Venta.Where(p => p.Id == id).FirstOrDefault();

            if (venta is not null)
            {
                venta.Comentarios = ventaDTO.Comentarios;
                venta.Id = ventaDTO.Id;
                venta.IdUsuario = ventaDTO.IdUsuario;

                this.coderContext.Venta.Update(venta);
                this.coderContext.SaveChanges();
                return true;
            }

            return false;


        }




    }
}
