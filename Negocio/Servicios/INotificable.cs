using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    internal interface INotificable
    {
        void Notificar(string contacto, string mensaje); 
    }
}
