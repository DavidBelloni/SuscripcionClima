using DAL.Contracts;
using Domain;
using Services.Exceptions;
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

        public void Add(Ciudad ciudad)
        {
            ciudades.Add(ciudad);
        }

        public void ActualizarCiudad(Ciudad ciudad)
        {
            // Buscamos la ciudad por nombre dentro de ciudades y luego actualizamos la lista de suscriptores
            var ciudadExistente = ciudades.FirstOrDefault(c => c.Nombre == ciudad.Nombre);
            if (ciudadExistente != null)
            {
                ciudadExistente.suscriptores = ciudad.suscriptores;
            }
            else
            {
                throw new CiudadNoEncontrada();

            }

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
