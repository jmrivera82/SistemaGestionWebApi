using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Models;
using System;
using System.Collections.Generic;

namespace SistemaGestionWebApi.Mapper
{
    public static class VentaMapper
    {

        public static Ventum MapearAVenta (VentaDTO dto)
        {

            Ventum venta = new Ventum();
            venta.Comentarios = dto.Comentarios;
            venta.Id = dto.Id;
            venta.IdUsuario = dto.IdUsuario;
         

            return venta;   

        }


        public static VentaDTO MapearADTO(Ventum venta)
        {
            VentaDTO dto = new VentaDTO();

            dto.Comentarios = venta.Comentarios;
            dto.Id = venta.Id;
            dto.IdUsuario = venta.IdUsuario;

            return dto;

        }


       
    }
}
