using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Repositories;

namespace Negocio
{
    public class ClienteNegocio
    {
        public void AddCliente(Cliente cliente)
        {
			ClienteRepository repository = new ClienteRepository();

			try
			{
				if (cliente == null)
					throw new NullReferenceException("Cliente es null");

				repository.Add(cliente);
			}
			catch (Exception)
			{

				throw;
			}
        }
    }
}
