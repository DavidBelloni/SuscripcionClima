
using BLL.Interface;
using BLL.Service;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Iniciamos el Servicio del Clima (conexion con la capa de negocio BLL)
            IClimaService climaService = new ClimaService();
            Console.WriteLine("Servicio del clima Iniciado - Conexion con BLL OK \n");

            // Creamos las Ciudades
            Console.WriteLine("Creamos las Ciudades:");
            Ciudad buenosAires = new Ciudad("Buenos Aires");
            Ciudad cordoba = new Ciudad("Cordoba");
            Console.WriteLine($" -{buenosAires.Nombre}");
            Console.WriteLine($" -{cordoba.Nombre} \n");


            // Registramos las ciudades en el servicio del clima
            Console.WriteLine("Registramos las Ciudades en el Servicio del Clima \n");
            climaService.CrearCiudad(buenosAires.Nombre);
            climaService.CrearCiudad(cordoba.Nombre);

            // Creamos los Usuarios
            Console.WriteLine("Creamos los Usuarios:");
            Usuario david = new Usuario("David");
            Usuario juan = new Usuario("Juan");

            Console.WriteLine($" -{david.Nombre}");
            Console.WriteLine($" -{juan.Nombre} \n");

            // Registramos los usuarios en la DAL
            Console.WriteLine("Guardamos los Usuarios en la DAL \n");
            climaService.CrearUsuario(david.Nombre);
            climaService.CrearUsuario(juan.Nombre);

            // Suscribimos los usuarios a las ciudades
            Console.WriteLine("Suscribimos los Usuarios a las Ciudades:");
            climaService.SuscribirUsuarioACiudad(david, buenosAires);
            climaService.SuscribirUsuarioACiudad(juan, cordoba);
            Console.WriteLine($" -{david.Nombre} suscripto a -> Ciudad: {buenosAires.Nombre}");
            Console.WriteLine($" -{juan.Nombre} suscripto a -> Ciudad: {cordoba.Nombre} \n");

            // Clima Actual en las Ciudades
            Console.WriteLine("Clima Actual en las Ciudades:\n");
            Console.WriteLine($" -Ciudad: {buenosAires.Nombre} Clima: {buenosAires.ClimaActual.Nombre} {buenosAires.ClimaActual.Temperatura}ºC {buenosAires.ClimaActual.Humedad}%");
            Console.WriteLine($" -Ciudad: {cordoba.Nombre} Clima: {cordoba.ClimaActual.Nombre} {cordoba.ClimaActual.Temperatura}ºC {cordoba.ClimaActual.Humedad}% \n");


            // Cambiamos las condiciones climáticas de las ciudades
            Console.WriteLine("Creamos algunos Climas Especificos \n");
            var clima1 = new CondicionMeteorologica("Soleado",30,60);
            var clima2 = new CondicionMeteorologica("Lluvioso", 5, 100);
            var clima3 = new CondicionMeteorologica("Nublado", 13, 85);
            Console.WriteLine($" -Clima 1: {clima1.Nombre} {clima1.Temperatura}ºC {clima1.Humedad}%");
            Console.WriteLine($" -Clima 2: {clima2.Nombre} {clima2.Temperatura}ºC {clima2.Humedad}%");
            Console.WriteLine($" -Clima 3: {clima3.Nombre} {clima3.Temperatura}ºC {clima3.Humedad}% \n");

            // Actualizamos las condiciones climáticas de las ciudades
            Console.WriteLine("Actualizamos las condiciones climáticas de las ciudades\n");
            climaService.CambiarCondicionClimatica(buenosAires, clima1);    
            climaService.CambiarCondicionClimatica(cordoba, clima2);


            // Desuscribimos a David de Buenos Aires
            Console.WriteLine($"\nDesuscribimos a {david.Nombre} de la ciudad {buenosAires.Nombre} \n");
            climaService.DesuscribirUsuarioDeCiudad(david, buenosAires);

            // Cambiamos nuevamente las condiciones climáticas de Buenos Aires
            Console.WriteLine("Cambiamos nuevamente las condiciones climáticas de ambas Ciudades \n");
            climaService.CambiarCondicionClimatica(buenosAires, clima2);
            climaService.CambiarCondicionClimatica(cordoba, clima3);

            
            Console.WriteLine("\n Presiona cualquier tecla para salir...");
            Console.ReadKey();







        }
    }
}
