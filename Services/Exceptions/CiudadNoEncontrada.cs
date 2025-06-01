using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Exceptions
{
    public class CiudadNoEncontrada : Exception
    {
        public CiudadNoEncontrada() : base("Ciudad no encontrada en el sistema.")
        {
        }
    }
}
