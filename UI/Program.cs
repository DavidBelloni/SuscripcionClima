
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
    //UI: Interfaz de usuario.Consola para ingresar comandos.
    //DOMAIN: Entidades y lógica del dominio (Ciudad, Usuario, CondicionClimatica, interfaces Observer/Subject).
    //BLL: Lógica de negocio(gestiona suscripciones, cambios de clima, etc).
    //DAL: Acceso a datos(simulado con listas en memoria o archivos simples).

    internal class Program
    {
        static void Main(string[] args)
        {

            IClimaService climaService = new ClimaService();

            Ciudad buenosAires = new Ciudad("Buenos Aires");
            Ciudad cordoba = new Ciudad("Cordoba");

            Usuario david = new Usuario("David");
            Usuario juan = new Usuario("Juan"); 

            climaService.SuscribirUsuarioACiudad(david, buenosAires);
            climaService.SuscribirUsuarioACiudad(juan, cordoba);

            var climaSoleado = new CondicionMeteorologica(35, 50);
            var climaLluvioso = new CondicionMeteorologica(12, 98);
            var climaNublado = new CondicionMeteorologica(20, 100);

            climaService.CambiarCondicionClimatica(buenosAires, climaSoleado);    
            climaService.CambiarCondicionClimatica(cordoba, climaLluvioso);
            
            climaService.DesuscribirUsuarioDeCiudad(david, buenosAires);

            climaService.CambiarCondicionClimatica(buenosAires, climaNublado);

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();







        }
    }
}
