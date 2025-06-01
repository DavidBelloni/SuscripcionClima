using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Interfaz que Implementa el Sujeto (Observable) que en este caso seria la "Ciudad"
    public interface ISujeto
    {
        // Permite Suscribir a sus observadores
        void SuscribirUsuario(IObservador usuario);

        // Permite Desuscribir a sus observadores
        void DesuscribirUsuario(IObservador usuario);
       
        // Permite notificar a sus observadores
        void Notificar();
    }
}
