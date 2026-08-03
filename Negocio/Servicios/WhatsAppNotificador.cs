using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Negocio.Servicios
{
    internal class WhatsAppNotificador : INotificable
    {
        public void Notificar(string telefono, string mensanje)
        {
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentNullException("El teléfono no es válido.");

            telefono.Replace("+", "")
                    .Replace(" ", "")
                    .Replace(".", "");

            if (telefono.StartsWith("0"))
                telefono = telefono.Substring(1);

            if (!(telefono.StartsWith("598")))
                telefono = "598" + telefono;

            string mensajeCodificado = Uri.EscapeDataString(mensanje);
            string url = $"https://wa.me/{telefono}?text={mensajeCodificado}";

            Process.Start(new ProcessStartInfo(url)
            {
                UseShellExecute = true,
            });
        }
    }
}