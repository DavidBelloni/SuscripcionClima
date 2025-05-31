using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    // Interfaz Suscriptora 
    public interface IObservador
    {
        void Actualizar(Ciudad ciudad, CondicionMeteorologica nuevaCondicion);
    }
}
