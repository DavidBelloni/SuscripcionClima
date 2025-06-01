using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Contracts
{
    public interface ICiudadRepository
    {
        void Add(Ciudad ciudad);

        void ActualizarCiudad(Ciudad ciudad);
        List<Ciudad> GetAll();
        Ciudad GetByName(string nombre);

    }
}
