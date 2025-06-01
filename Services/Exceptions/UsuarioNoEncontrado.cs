using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions
{
    public class UsuarioNoEncontrado : Exception
    {
        public UsuarioNoEncontrado() : base("Usuario no encontrado en el sistema.")
        {
        }
    }
}
