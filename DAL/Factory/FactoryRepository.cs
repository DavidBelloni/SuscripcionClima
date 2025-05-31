using DAL.Contracts;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
    public class FactoryRepository
    {
        private static int backendType = 0;

        static FactoryRepository()
        {

            backendType = int.Parse(ConfigurationManager.AppSettings["BackendType"]);
        }

        public static ICiudadRepository ClimaRepository
        {
            get
            {
                if (backendType == (int)BackendType.Memory)
                    return DAL.Implementation.Memory.ClimaRepository.Current;

                else
                    throw new Exception("BackendType no disponible");
            }
        }

    }



    internal enum BackendType
    {
        Memory,
        SqlServer
    }
}
