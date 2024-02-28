using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Models;
using System;
using System.Collections.Generic;

namespace SistemaGestionWebApi.Mapper
{
    public static class ProductoVendidoMapper
    {

        public static ProductoVendido MapearAProductoVendido (ProductoVendidoDTO dto)
        {

            ProductoVendido productoVendido = new ProductoVendido();
            productoVendido.Stock = dto.Stock;
            productoVendido.Id = dto.Id;
            productoVendido.IdProducto = dto.IdProducto;
            productoVendido.IdVenta = dto.IdVenta;
      

            return productoVendido;

        }


        public static ProductoVendidoDTO MapearADTO(ProductoVendido productoVendido)
        {
            ProductoVendidoDTO dto = new ProductoVendidoDTO();

            dto.Stock = productoVendido.Stock;
            dto.Id = productoVendido.Id;
            dto.IdProducto = productoVendido.IdProducto;
            dto.IdVenta = productoVendido.IdVenta;

            return dto;

        }


       
    }
}
