using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Data.Repositories
{
    public class ClienteRepository
    {
        public List<Cliente> GetAll() 
        {
            DataAccess Data = new DataAccess();
            List<Cliente> clientes = new List<Cliente>();
            Cliente Aux = new Cliente();

            try
            {

                Data.SetQuery("");

                while (Data.Reader.Read())
                {

                }

                return clientes;

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                Data.ConnectionClose();
            }
        }
    }
}
