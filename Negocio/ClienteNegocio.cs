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
        public Cliente Add(Cliente cliente)
        {
            var repository = new ClienteRepository();

            try
            {
                if (cliente == null)
                    throw new NullReferenceException("Cliente es null");

                cliente = repository.Add(cliente);

                if (cliente != null)
                    return cliente;

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
