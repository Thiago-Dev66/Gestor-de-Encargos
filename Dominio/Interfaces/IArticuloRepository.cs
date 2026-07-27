using System.Collections.Generic;

namespace Dominio.Interfaces
{
    public interface IArticuloRepository
    {
        void Add(Articulo articulo);
        List<Articulo> GetAll();
        void Update(Articulo articulo);
        void Delete(int Id);
    }
}