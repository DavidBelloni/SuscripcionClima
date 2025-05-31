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

        #region
        // Instancia privada estatica y de solo lectura para el Singleton
        private static readonly CiudadRepository instance = new CiudadRepository();

        // Metodo publico con acceso global
        public static CiudadRepository Current
        {
            get { return instance; }
        }

        // Constructor privado para evitar instanciación externa
        private CiudadRepository() 
        { 
        }
        #endregion

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
