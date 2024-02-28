using System;
using System.Collections.Generic;

namespace SistemaGestionWebApi.DTOs
{
    public class VentaDTO
    {

        public int Id { get; set; }
        public string? Comentarios { get; set; }
        public int IdUsuario { get; set; }

    }
}
