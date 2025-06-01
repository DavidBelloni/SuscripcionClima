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
    // Implementa la interfaz IObservador con el metodo Actualizar que recibe la ciudad y la nueva condicion meteorologica
    public class Usuario : IObservador
    {
        public string Nombre {  get; set; }
        public List<Ciudad> CiudadesSuscritas { get; set; } = new List<Ciudad>();
        public Usuario(string nombre)
        {
            Nombre = nombre;
        }

        public void Actualizar(Ciudad ciudad, CondicionMeteorologica nuevaCondicion)
        {
            Console.WriteLine($"{Nombre} ha sido notificado: El clima en {ciudad.Nombre} cambió a {nuevaCondicion.Nombre} {nuevaCondicion.Temperatura}°C {nuevaCondicion.Humedad}%");
        }

        public void SuscribirCiudad(Ciudad ciudad)
        {
            if (!CiudadesSuscritas.Contains(ciudad))
            {
                CiudadesSuscritas.Add(ciudad);
            }
        }

        public void DesuscribirCiudad(Ciudad ciudad)
        {
            if (CiudadesSuscritas.Contains(ciudad))
            {
                CiudadesSuscritas.Remove(ciudad);
            }
        }
    }
}
