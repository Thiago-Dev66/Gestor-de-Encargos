using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repositories;
using Dominio;

namespace Negocio
{
    public class VendedorNegocio
    {

        public void Add(Vendedor vendedor)
        {
            var repository = new VendedorRepository();

            if (vendedor == null)
                throw new Exception("Vendedor es null");

            if (vendedor.Numero <= 0)
                throw new Exception("El número de vendedor no puede ser menor o igual cero");

            repository.Add(vendedor);
        }

        public Vendedor Validar(int number)
        {
            var repository = new VendedorRepository();

            if (number <= 0)
                throw new Exception("El número de vendedor no puede ser menor o igual cero");

            return repository.Validar(number);
        }
    }
}
