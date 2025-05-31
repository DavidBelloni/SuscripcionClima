using BLL.Interface;
using DAL.Contracts;
using DAL.Factory;
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
        private readonly ICiudadRepository ciudadRepository;
        private readonly IUsuarioRepository usuarioRepository;

        public ClimaService()
        {
            ciudadRepository = FactoryRepository.CiudadRepository;
            usuarioRepository = FactoryRepository.UsuarioRepository;
        }

        public void CambiarCondicionClimatica(Ciudad ciudad, CondicionMeteorologica nuevaCondicion)
        {
            ciudad.CambiarClima(nuevaCondicion);
        }

        public Ciudad CrearCiudad(string nombre)
        {
            Ciudad ciudad = new Ciudad(nombre);
            ciudadRepository.Add(ciudad);
            return ciudad;
        }

        public Usuario CrearUsuario(string nombre)
        {
            Usuario usuario = new Usuario(nombre);
            usuarioRepository.Add(usuario);
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
            return ciudadRepository.GetAll();
        }

        public List<Usuario> ListarUsuarios()
        {
            return usuarioRepository.GetAll();
        }
    }
}
