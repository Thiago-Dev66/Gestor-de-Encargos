using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Data;
using Data.Repositories;

namespace Negocio
{
    public class EncargosNegocio
    {
        private readonly EncargosRepository _encargosRepository;

        public EncargosNegocio (EncargosRepository encargosRepository)
        {
            _encargosRepository = encargosRepository;
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new Exception("Un ID no puede ser menor o igual a cero");

            _encargosRepository.Delete(id);
        }

        public void Save(Encargo encargo) 
        {
            try
            {
                if (string.IsNullOrEmpty(encargo.SucursalOrigen))
                    throw new Exception("La sucursal de origen es obligatoria");

                if (encargo.Fecha == null)
                    throw new Exception("Un encargo debe tener una fecha");

                _encargosRepository.Add(encargo);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(Encargo encargo)
        {
            if (encargo == null)
                throw new Exception("Un encargo no puede ser null");

            _encargosRepository.Update(encargo);
        }
    }
}
