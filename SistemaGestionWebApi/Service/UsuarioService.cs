using SistemaGestionWebApi.Database;
using SistemaGestionWebApi.DTOs;
using SistemaGestionWebApi.Mapper;
using SistemaGestionWebApi.Models;

namespace SistemaGestionWebApi.Service
{
    public class UsuarioService
    {
        private CoderContext coderContext;

        public UsuarioService(CoderContext coderContext) 
        
        {
            this.coderContext = coderContext;
        }



        public List<Usuario> ObtenerListadoDeUsuario()
        {
            return this.coderContext.Usuarios.ToList();
        }

        public bool AgregarUnUsuario(UsuarioDTO dto)
        {

            Usuario p = UsuarioMapper.MapearAUsuario(dto);


            this.coderContext.Usuarios.Add(p);
            this.coderContext.SaveChanges();
            return true;
        }

    }
}
