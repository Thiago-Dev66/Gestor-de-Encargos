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

        public void AddVendedor(Vendedor vendedor)
        {
            VendedorRepository repository = new VendedorRepository();

            try
            {
                repository.Add(vendedor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool ValidarVendedor(int val)
        {
            VendedorRepository repository = new VendedorRepository();

            if(repository.ValidarVendedor(val))
                return true;

            return false;
        }
    }
}
