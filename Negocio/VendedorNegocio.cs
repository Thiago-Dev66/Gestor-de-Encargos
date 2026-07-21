using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repositories;
using Dominio;
using Dominio.Interfaces;

namespace Negocio
{
    public class VendedorNegocio
    {
        private readonly IVendedorRepository _repository;

        public VendedorNegocio(IVendedorRepository repository)
        {
            _repository = repository;
        }

        public void Add(Vendedor vendedor)
        {
            if (vendedor == null)
                throw new Exception("Vendedor es null");
            if (vendedor.Numero <= 0)
                throw new Exception("El número de vendedor no puede ser menor o igual cero");

            _repository.Add(vendedor);
        }
        public List<Vendedor> GetAll()
        {
            return _repository.GetAll();
        }
        public void Update(Vendedor vendedor)
        {
            try
            {
                if (vendedor == null)
                    throw new Exception("Vendedor es null");
                if (vendedor.Numero <= 0)
                    throw new Exception("El número de vendedor no puede ser menor o igual cero");

                _repository.Update(vendedor);
            }
            catch (Exception exc)
            {
                throw new Exception("No se pudo modificar vendedor", exc);
            }
        }
        public void Delete(int number)
        {
            if (number <= 0)
                throw new Exception("El número de vendedor no puede ser menor o igual cero");

            _repository.Delete(number);
        }
        public Vendedor Validar(int number)
        {
            if (number <= 0)
                throw new Exception("El número de vendedor no puede ser menor o igual cero");

            return _repository.Validar(number);
        }
    }
}
