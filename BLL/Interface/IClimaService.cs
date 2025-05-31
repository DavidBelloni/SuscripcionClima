using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IClimaService
    {
        Ciudad CrearCiudad(string nombre);
        Usuario CrearUsuario(string nombre);
        List<Ciudad> ListarCiudades();
        List<Usuario> ListarUsuarios();

        void SuscribirUsuarioACiudad(Usuario usuario, Ciudad ciudad);
        void DesuscribirUsuarioDeCiudad(Usuario usuario, Ciudad ciudad);
        void CambiarCondicionClimatica(Ciudad ciudad, CondicionMeteorologica nuevaCondicion);
    }
}
