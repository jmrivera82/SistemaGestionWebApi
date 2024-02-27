using System;
using System.Collections.Generic;

namespace SistemaGestionWebApi.Models
{
    public partial class Cliente
    {
        public int Id { get; set; }
        public string NombreApellido { get; set; } = null!;
        public string Domicilio { get; set; } = null!;
        public int? Telefono { get; set; }
    }
}
