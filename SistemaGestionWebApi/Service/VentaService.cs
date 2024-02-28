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
    }
}
