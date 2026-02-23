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
        public void Save(Encargo encargo) 
        {
            EncargosRepository repository = new EncargosRepository();

            try
            {
                if (string.IsNullOrEmpty(encargo.SucursalOrigen))
                    throw new Exception("La sucursal de origen es obligatoria");

                if (encargo.Fecha == null)
                    throw new Exception("Un encargo debe tener una fecha");

                repository.Add(encargo);

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(Encargo encargo)
        {
            EncargosRepository repository = new EncargosRepository();

            repository.Update(encargo);
        }
    }
}
