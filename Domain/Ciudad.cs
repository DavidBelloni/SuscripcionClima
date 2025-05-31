using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Es el Sujeto
    // Mantiene una lista de suscriptores (Usuario = Observadores)
    // Tiene un metodo para cambiar el clima y notifica a los suscriptores (Usuario = Observadores)
    public class Ciudad : ISujeto
    {

        public string Nombre { get; set; }
        public CondicionMeteorologica ClimaActual { get; private set; }
        
        private List<IObservador> suscriptores = new List<IObservador>();

        public Ciudad(string nombre)
        {
            Nombre = nombre;
            ClimaActual = new CondicionMeteorologica("Despejado",20, 50); // Inicializa con valores por defecto
        }

        public void CambiarClima(CondicionMeteorologica nuevaCondicion)
        {
            ClimaActual = nuevaCondicion;
            Notificar();
        }

        public void Suscribir(IObservador usuario)
        {
            if (!suscriptores.Contains(usuario))
                suscriptores.Add(usuario);
        }

        public void Desuscribir(IObservador usuario)
        {
            suscriptores.Remove(usuario);
        }

        public void Notificar()
        {
            foreach (var usuario in suscriptores)
            {
                usuario.Actualizar(this, ClimaActual);
            }
        }
    }
}
