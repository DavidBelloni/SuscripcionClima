using Domain;
using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Es un Observador
    // Implementa la interfaz IObservador
    // Implementa el metodo Actualizar que recibe la ciudad y la nueva condicion meteorologica
    public class Usuario : IObservador
    {
        public string Nombre {  get; set; }

        
        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public void Actualizar(Ciudad ciudad, CondicionMeteorologica nuevaCondicion)
        {
            Console.WriteLine($"{Nombre} ha sido notificado: El clima en {ciudad.Nombre} cambió a Humedad:({nuevaCondicion.Humedad}) y ({nuevaCondicion.Temperatura}°C)");
        }
    }
}
