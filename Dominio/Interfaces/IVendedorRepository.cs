using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Interfaces
{
    public interface IVendedorRepository
    {
        void Add(Vendedor NewVendedor);
        List<Vendedor> GetAll();
        void Update(Vendedor Modified);
        void Delete(int id);
        Vendedor Validar(int number);
    }
}
