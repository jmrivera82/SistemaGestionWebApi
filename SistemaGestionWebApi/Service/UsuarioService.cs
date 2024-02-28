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

        public bool BorrarUsuarioPorId(int id)
        {
            Usuario? usuario = this.coderContext.Usuarios.Where(p => p.Id == id).FirstOrDefault();

            if (usuario is not null)
            {
                this.coderContext.Remove(usuario);
                this.coderContext.SaveChanges();
                return true;
            }

            return false;


        }


        public bool ActualizarUsuarioPorId(int id, UsuarioDTO usuarioDTO)
        {
            Usuario? usuario = this.coderContext.Usuarios.Where(p => p.Id == id).FirstOrDefault();

            if (usuario is not null)
            {
                usuario.Nombre = usuarioDTO.Nombre;
                usuario.Apellido = usuarioDTO.Apellido;
                usuario.NombreUsuario = usuarioDTO.NombreUsuario;

                usuario.Contraseña = usuarioDTO.Contraseña;

                usuario.Mail = usuarioDTO.Mail;


                this.coderContext.Usuarios.Update(usuario);
                this.coderContext.SaveChanges();
                return true;
            }

            return false;


        }


    }
}

    

