using System;
using System.Collections.Generic;

namespace SistemaGestionWebApi.DTOs
{
    public class ProductoVendidoDTO
    {

        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdProducto { get; set; }
        public int IdVenta { get; set; }

    }
}
