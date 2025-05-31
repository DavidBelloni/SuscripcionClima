using BLL.Interface;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Service
{
    public class ClimaService : IClimaService
    {
        private readonly List<Ciudad> ciudades = new List<Ciudad>();
        private readonly List<Usuario> usuarios = new List<Usuario>();

        public void CambiarCondicionClimatica(Ciudad ciudad, CondicionMeteorologica nuevaCondicion)
        {
            ciudad.CambiarClima(nuevaCondicion);
        }

        public Ciudad CrearCiudad(string nombre)
        {
            Ciudad ciudad = new Ciudad(nombre);
            ciudades.Add(ciudad);
            return ciudad;
        }

        public Usuario CrearUsuario(string nombre)
        {
            Usuario usuario = new Usuario(nombre);
            usuarios.Add(usuario);
            return usuario;
        }
        public void SuscribirUsuarioACiudad(Usuario usuario, Ciudad ciudad)
        {
            if (usuario != null && ciudad != null)
            {
                ciudad.Suscribir(usuario);
            }
        }

        public void DesuscribirUsuarioDeCiudad(Usuario usuario, Ciudad ciudad)
        {
            if  (usuario != null && ciudad != null)
            {
                ciudad.Desuscribir(usuario);
            }
        }

        public List<Ciudad> ListarCiudades()
        {
            return ciudades;
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarios;
        }
    }
}
