using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Implementation.Memory
{
    public class CiudadRepository : ICiudadRepository
    {
        private readonly List<Ciudad> ciudades = new List<Ciudad>();

        public void Add(Ciudad ciudad)
        {
            ciudades.Add(ciudad);
        }

        public List<Ciudad> GetAll()
        {
            return ciudades;
        }

        public Ciudad GetByName(string nombre)
        {
            return ciudades.FirstOrDefault(c => c.Nombre == nombre);
        }
    }
}
