using Dominio;
using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class ArticuloRepository
    {
        public void Add(Articulo articulo, DataAccess data = null)
        {
            bool shouldDispose = data == null;
            data = data ?? new DataAccess();

            try
            {
                data.SetQuery(@"
                        INSERT INTO Articulos (Codigo, Nombre, Precio) 
                        VALUES (@Codigo, @Nombre, @Precio) 
                        ");

                data.SetParameter("@Codigo", articulo.Codigo);
                data.SetParameter("@Nombre", articulo.Nombre);
                data.SetParameter("@Precio", articulo.Precio);

                data.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (shouldDispose)
                    data?.Dispose();
            }
        }
        public int GetOrCreate(Articulo articulo, DataAccess data = null)
        {
            bool shouldDispose = data == null;
            data = data ?? new DataAccess();

            List<Articulo> articulos;
            int articuloId = 0;

            try
            {
                articulos = GetAll(data);

                foreach (var item in articulos)
                {
                    if (articulo.Codigo == item.Codigo)
                    {
                        articuloId = item.Id;
                        return articuloId;
                    }
                }
                Add(articulo, data);

                return articuloId;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (shouldDispose)
                    data?.Dispose();
            }
        }
        public List<Articulo> GetAll(DataAccess data = null)
        {
            bool shouldDispose = data == null;
            data = data ?? new DataAccess();

            List<Articulo> articulos = new List<Articulo>();
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
                        Codigo = (string)data.Reader["Codigo"],
                        Nombre = (string)data.Reader["Nombre"]
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
                if (shouldDispose)
                    data?.Dispose();
            }

        }

        public BindingList<ArticuloEncargo> GetArticulosByEncargoId(int id)
        {
            BindingList<ArticuloEncargo> articulosEncargos = new BindingList<ArticuloEncargo>();
            ArticuloEncargo articuloEncargo;

            using (var data = new DataAccess())
            {
                try
                {
                    data.SetQuery(@"
                            SELECT A.Id, A.Nombre, A.Codigo, AE.Cantidad 
                            FROM ArticulosEncargos AS AE
                            JOIN ARTICULOS AS A ON AE.ArticuloID = A.ID
                            WHERE EncargoID = @EncargoId
                            ");

                    data.SetParameter("@EncargoId", id);
                    data.ExecuteReader();

                    while (data.Reader.Read())
                    {
                        articuloEncargo = new ArticuloEncargo()
                        {
                            Articulo = new Articulo()
                            {
                                Id = Convert.ToInt32(data.Reader["Id"]),
                                Nombre = (string)data.Reader["Nombre"],
                                Codigo = (string)data.Reader["Codigo"]
                            },

                            Cantidad = Convert.ToInt32(data.Reader["Cantidad"]),
                        };

                        articulosEncargos.Add(articuloEncargo);
                    }

                    return articulosEncargos;
                }
                catch (Exception)
                {
                    throw;
                }
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
