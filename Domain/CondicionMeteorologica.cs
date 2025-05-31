using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Es un simple Objeto de dato que representa el clima actual de una ciudad
    // Es un objeto de Interes para los usuarios
    public class CondicionMeteorologica
    {
        public string Nombre { get; set; }
        public int Temperatura { get; private set; }
        public int Humedad { get; private set; }


        public CondicionMeteorologica(string nombre, int temperatura, int humedad)
        {
            Nombre = nombre;
            Temperatura = temperatura;
            Humedad = humedad;
        }
    }
}
