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
        private readonly INotificable _notificable;

        public EncargosNegocio()
        {
        }

        public EncargosNegocio(EncargosRepository encargosRepository)
        {
            _encargosRepository = encargosRepository;
            _notificable = new WhatsAppNotificador();
        }

        public void NotificarCliente(Encargo encargo)
        {
            try
            {
                if (encargo == null)
                    throw new ArgumentNullException("Un encargo no puede ser null");

                string articulos = string.Join("\n• ", encargo.ArticuloEncargo
                                         .Select(a => a.Articulo.Nombre));

                StringBuilder mensaje = new StringBuilder();

                mensaje.AppendLine($"Hola, {encargo.Cliente.Nombre}! ");
                mensaje.AppendLine($"Te habla {encargo.Vendedor.Nombre} de Palacio de la Música Las Piedras Shopping. " +
                                    "Tu pedido ya está listo para retirar: ");
                mensaje.AppendLine($"• {articulos} ");
                mensaje.AppendLine();
                mensaje.AppendLine("Podés pasar de lunes a domingos de 11h a 22h");
                mensaje.AppendLine("Te esperamos!");

               _notificable.Notificar(encargo.Cliente.Celular, mensaje.ToString());
            }
            catch (Exception)
            {
                throw;
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
