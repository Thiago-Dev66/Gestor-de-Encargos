using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Data.Repositories;
using Dominio.Interfaces;

namespace Negocio
{
    public class ClienteNegocio
    {
        private readonly IClienteRepository _repository;

        public ClienteNegocio(IClienteRepository repository)
        {
            _repository = repository;
        }

        public List<Cliente> GetClientes()
        {
            try
            {
                return _repository.GetAll();
            }
            catch (Exception exc)
            {
                throw exc;
            }
        }

        public Cliente Add(Cliente cliente)
        {
            try
            {
                if (cliente == null)
                    throw new NullReferenceException("Cliente es null");

                cliente = _repository.Add(cliente);

                if (cliente != null)
                    return cliente;

                return null;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void Modificar(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                    _repository.Update(cliente);
            }
            catch (Exception exc)
            {
                throw new Exception("No se pudo modificar Cliente", exc);
            }
        }
        public void Eliminar(Cliente cliente)
        {
            try
            {
                if (cliente != null)
                    _repository.Delete(cliente.Id);
            }
            catch (Exception exc)
            {
                throw new Exception("No se pudo eliminar Cliente", exc);
            }
        }
    }
}
