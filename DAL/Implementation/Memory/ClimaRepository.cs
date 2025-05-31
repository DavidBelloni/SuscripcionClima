using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Memory
{
    public class ClimaRepository : ICiudadRepository
    {
        private List<Usuario> usuarios = new List<Usuario>();

        #region singleton

        private readonly static ClimaRepository _instance = new ClimaRepository();
       
        public static ClimaRepository Current
        {
            get
            {
                return _instance;
            }
        }
        
        private ClimaRepository()
        {

        }
        #endregion

        public void SuscribirUsuario(Usuario usuario, Ciudad ciudad)
        {
            if (usuario == null || ciudad == null)
            {
                throw new ArgumentNullException("Usuario o Ciudad no pueden ser nulos.");
            }
            if (!usuarios.Contains(usuario))
            {
                usuarios.Add(usuario);
                Console.WriteLine($"Usuario {usuario.Nombre} suscrito a las actualizaciones de clima en {ciudad.Nombre}.");
            }
            else
            {
                Console.WriteLine($"El usuario {usuario.Nombre} ya está suscrito.");
            }

        }
   

        public void DesuscribirUsuario()
        {

        }

    }
}
