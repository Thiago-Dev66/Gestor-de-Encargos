using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IClienteRepository
    {
        List<Cliente> GetAll();
        Cliente Add(Cliente cliente);
        void Update(Cliente Modified);
        void Delete(int id);
    }
}
