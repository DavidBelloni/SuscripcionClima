using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Interfaz Notificadora 
    public interface ISujeto
    {
        void Suscribir(IObservador usuario);
        void Desuscribir(IObservador usuario);
        void Notificar();
    }
}
