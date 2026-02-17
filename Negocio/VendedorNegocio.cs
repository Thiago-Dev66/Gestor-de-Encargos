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

        public Vendedor ValidarVendedor(int val)
        {
            VendedorRepository repository = new VendedorRepository();
            Vendedor vendedor;

            try
            {
                vendedor = (Vendedor)repository.ValidarVendedor(val);

                if (vendedor != null) 
                    return vendedor;
                else
                    throw new NullReferenceException("Número inválido");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                return null;
                
            }
        }
    }
}
