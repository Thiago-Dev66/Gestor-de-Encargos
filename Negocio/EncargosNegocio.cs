using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Data;
using Data.Repositories;
using Negocio.Servicios;
using System.Windows.Forms;

namespace Negocio
{
    public class EncargosNegocio
    {
        private readonly EncargosRepository _encargosRepository;
        private readonly ConfiguracionRepository _configuracionRepository;
        private readonly INotificable _notificable;
        public StringBuilder mensaje;

        public EncargosNegocio()
        {
        }

        public EncargosNegocio(EncargosRepository encargosRepository)
        {
            _encargosRepository = encargosRepository;
            _notificable = new WhatsAppNotificador();
        }

        public void NotificarCliente(string mensaje, string contacto)
        {
            try
            {
                if (string.IsNullOrEmpty(mensaje))
                    throw new ArgumentNullException("El mensaje no puede ser null");

               _notificable.Notificar(contacto, mensaje);
            }
            catch (Exception exc)
            {
                throw new Exception("El mensaje no se pudo envíar", exc);
            }
        }
        public void IsNotified(bool isNotified, Encargo encargo)
        {
            if (encargo == null)
                throw new NullReferenceException("Un encargo no puede ser null");

            if (isNotified == true)
                _encargosRepository.UpdateState(encargo);
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new Exception("Un ID no puede ser menor o igual a cero");

            _encargosRepository.Delete(id);
        }

        public void Save(Encargo encargo)
        {
            try
            {
                if (string.IsNullOrEmpty(encargo.SucursalOrigen))
                    throw new Exception("La sucursal de origen es obligatoria");

                if (encargo.Fecha == null)
                    throw new Exception("Un encargo debe tener una fecha");

                _encargosRepository.Add(encargo);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Encargo encargo)
        {
            if (encargo == null)
                throw new Exception("Un encargo no puede ser null");

            _encargosRepository.Update(encargo);
        }
    }
}
