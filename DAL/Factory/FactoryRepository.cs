using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    // Gracias a la Factory la BLL toma los repositorios directamente segun la config de app.config
    public class FactoryRepository
    {
        private static int backendType = 0;

        static FactoryRepository()
        {

            backendType = int.Parse(ConfigurationManager.AppSettings["BackendType"]);
        }

        public static ICiudadRepository CiudadRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.CiudadRepository.Current;

                else
                    throw new Exception("BackendType no disponible");
            }
        }

        public static IUsuarioRepository UsuarioRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.UsuarioRepository.Current;
                else
                    throw new Exception("BackendType no disponible");
            }
        }

    }



    internal enum BackendType
    {
        Memory = 0,
        SqlServer = 1
    }
}
