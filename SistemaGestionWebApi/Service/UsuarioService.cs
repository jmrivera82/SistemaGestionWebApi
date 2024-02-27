using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class UsuarioService
    {
        private CoderContext context;

        public UsuarioService(CoderContext coderContext) 
        
        {
            this.context = coderContext;
        }



        public List<Usuario> ObtenerListadoDeUsuario()
        {
            return this.context.Usuarios.ToList();
        }

    }
}
