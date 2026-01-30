using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Dominio;

namespace Data.Repositories
{
    public class ArticuloRepository
    {
        public void Add(Articulo articulo)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.BeginTransaction();

                data.SetQuery(@"
                        INSERT INTO Articulos (Codigo, Nombre, Precio) 
                        VALUES (@Codigo, @Nombre, @Precio) 
                ");

                data.SetParameter("@Codigo", articulo.Codigo);
                data.SetParameter("@Nombre", articulo.Nombre);
                data.SetParameter("@Precio", articulo.Precio);

                data.ExecuteNonQuery();

                data.Commit();

            }
            catch (Exception)
            {
                data.Rollback();
                throw;
            }
            finally
            {
                data.ConnectionClose();
            }

        }
        public List<Articulo> GetAll()
        {
            List<Articulo> articulos = new List<Articulo>();
            DataAccess data = new DataAccess();
            Articulo aux;

            try
            {

                data.SetQuery(@"
                    SELECT Id, Codigo, Nombre, Precio
                    FROM Articulos
                ");

                data.ExecuteReader();

                while (data.Reader.Read())
                {
                    aux = new Articulo()
                    {
                        Id = Convert.ToInt32(data.Reader["Id"]),
                        Codigo = Convert.ToInt32(data.Reader["Codigo"]),
                        Nombre = (String)data.Reader["Nombre"]
                    };
                        if (!(data.Reader["Precio"] is DBNull))
                            aux.Precio = Convert.ToDouble(data.Reader["Precio"]);


                    articulos.Add(aux);
                }

                return articulos;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            { 
                data.ConnectionClose();
            }

        }
        public void Update(Articulo articulo)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.BeginTransaction();

                data.SetQuery(@"
                    UPDATE Articulos SET
                        Codigo = @Codigo, 
                        Nombre = @Nombre, 
                        Precio = @Precio
                    WHERE Id = @Id
                ");

                data.SetParameter("@Id", articulo.Id);
                data.SetParameter("@Codigo", articulo.Codigo);
                data.SetParameter("@Nombre", articulo.Nombre);
                data.SetParameter("@Precio", articulo.Precio);

                data.ExecuteNonQuery();

                data.Commit();

            }
            catch (Exception)
            {
                data.Rollback();
                throw;
            }
            finally
            {
                data.ConnectionClose(); 
            }

        }
        public void Delete(int id)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.BeginTransaction();

                data.SetQuery(@"DELETE FROM Articulos WHERE Id = @Id");
                data.SetParameter("@Id", id);
                data.ExecuteNonQuery();

                data.Commit();

            }
            catch (Exception)
            {
                data.Rollback();
                throw;
            }
            finally 
            {
                data.ConnectionClose();
            }

        }
    }
}
