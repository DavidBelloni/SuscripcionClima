using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface IClimaRepository
    {
        void SuscribirUsuario(Usuario usuario, Ciudad ciudad);
        void DesuscribirUsuario();
        
    }
}
