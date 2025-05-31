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
        void Suscribir(IObservador usuario);
        void Desuscribir(IObservador usuario);
        void Notificar();
    }
}
