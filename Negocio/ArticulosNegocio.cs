using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Repositories;
using Data;

namespace Negocio
{
    public class ArticulosNegocio
    {
        public void Save(ArticuloEncargo articuloEncargo)
        {
			ArticuloRepository repository = new ArticuloRepository();

			try
			{
				if (articuloEncargo != null)
				{
					if (string.IsNullOrEmpty(articuloEncargo.ArticuloCodigo))
						throw new Exception("Código inválido");
					if (string.IsNullOrEmpty(articuloEncargo.ArticuloNombre))
						throw new Exception("Un articulo debe tener un nombre");

					repository.Add(articuloEncargo.Articulo);
				}
				else
					throw new NullReferenceException();

			}
			catch (Exception)
			{
				throw;
			}
        }
    }
}
