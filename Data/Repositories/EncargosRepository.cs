using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Data.Repositories
{
    public class EncargosRepository
    {

        public int Add(Encargo encargo)
        {
            ArticuloRepository articuloRepository = new ArticuloRepository();
            Articulo articulo;

            using (var data = new DataAccess())
            {
                try
                {
                    data.BeginTransaction();

                    data.SetQuery(@"
                        INSERT INTO Encargos 
                        (Fecha, Estado, Descripcion, SucursalOrigen, ClienteId, VendedorId)
                        VALUES 
                        (@Fecha, @Estado, @Descripcion, @SucursalOrigen, @ClienteId, @VendedorId)
                        ");

                    data.SetParameter("@Fecha", encargo.Fecha);
                    data.SetParameter("@Estado", (int)encargo.Estado);
                    data.SetParameter("@Descripcion", encargo.Descripcion);
                    data.SetParameter("@SucursalOrigen", encargo.SucursalOrigen);
                    data.SetParameter("@ClienteId", encargo.Cliente.Id);
                    data.SetParameter("@VendedorId", encargo.Vendedor.Id);

                    data.ExecuteNonQuery();

                    data.SetQuery("SELECT last_insert_rowid()");
                    object scalar = data.ExecuteScalar();

                    if (scalar == null || scalar == DBNull.Value)
                        throw new InvalidOperationException("Ningún ID fue retornado");

                    int encargoId = Convert.ToInt32(scalar);

                    foreach (var item in encargo.ArticuloEncargo)
                    {
                        articulo = new Articulo();

                        articulo.Codigo = item.ArticuloCodigo;
                        articulo.Nombre = item.ArticuloNombre;

                        long IdArticulo = articuloRepository.GetOrCreate(articulo, data);

                        if (IdArticulo == 0)
                        {
                            data.SetQuery("SELECT last_insert_rowid()");
                            IdArticulo = (long)data.ExecuteScalar();
                        }

                        data.SetQuery(@"
                            INSERT INTO ArticulosEncargos 
                                (ArticuloId, EncargoId, Cantidad, PrecioUnitario)
                            VALUES
                                (@ArticuloId, @EncargoId, @Cantidad, @PrecioUnitario)
                            ");

                        data.SetParameter("@ArticuloId", IdArticulo);
                        data.SetParameter("@EncargoId", encargoId);
                        data.SetParameter("@Cantidad", item.Cantidad);
                        data.SetParameter("@PrecioUnitario", item.PrecioUnitario);

                        data.ExecuteNonQuery();
                    }

                    data.Commit();

                    return encargoId;

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

        public List<Encargo> GetAll()
        {
            Encargo encargo;
            List<Encargo> encargos = new List<Encargo>();
            int estado;

            using (var data = new DataAccess())
            {
                try
                {
                    data.SetQuery(@"
                            SELECT E.Id, C.Nombre as Cliente, C.Celular, V.Numero AS Vendedor, 
                            date(E.Fecha) as Fecha, E.Estado, E.SucursalOrigen as Sucursal, E.Descripcion, 
                            E.ClienteID, E.VendedorID   
                            FROM Encargos AS E
                            JOIN Clientes AS C ON E.ClienteId = C.Id
                            JOIN Vendedores AS V ON E.VendedorId = V.Id
                            ");

                    data.ExecuteReader();

                    while (data.Reader.Read())
                    {
                        encargo = new Encargo()
                        {
                            Cliente = new Cliente(),
                            Vendedor = new Vendedor()
                        };

                        encargo.Id = Convert.ToInt32(data.Reader["Id"]);
                        encargo.Cliente.Nombre = (string)data.Reader["Cliente"];
                        encargo.Cliente.Celular = (string)data.Reader["Celular"];
                        encargo.Fecha = DateTime.Parse(data.Reader["Fecha"].ToString());
                        estado = Convert.ToInt32(data.Reader["Estado"]);
                        encargo.Estado = (EstadoEncargo)estado;
                        encargo.Vendedor.Numero = Convert.ToInt32(data.Reader["Vendedor"]);
                        encargo.SucursalOrigen = (string)data.Reader["Sucursal"];

                        if (!(data.Reader["Descripcion"] is DBNull))
                            encargo.Descripcion = (string)data.Reader["Descripcion"];

                        encargo.Cliente.Id = Convert.ToInt32(data.Reader["ClienteID"]);
                        encargo.Vendedor.Id = Convert.ToInt32(data.Reader["VendedorID"]);

                        encargos.Add(encargo);
                    }

                    return encargos;
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

        }

        public void Update(Encargo encargo)
        {
            ArticuloRepository articuloRepository = new ArticuloRepository();
            Articulo articulo;

            using (var data = new DataAccess())
            {
                try
                {
                    data.BeginTransaction();

                    data.SetQuery(@" 
                        UPDATE Encargos SET 
                            Fecha = @Fecha, 
                            Estado = @Estado,  
                            Descripcion = @Descripcion,
                            SucursalOrigen = @SucursalOrigen,
                            ClienteID = @ClienteID,
                            VendedorID = @VendedorID
                        WHERE Id = @Id
                    ");

                    data.SetParameter(@"Id", encargo.Id);
                    data.SetParameter("@Fecha", encargo.Fecha);
                    data.SetParameter("@Estado", (int)encargo.Estado);
                    data.SetParameter("@Descripcion", encargo.Descripcion);
                    data.SetParameter("@SucursalOrigen", encargo.SucursalOrigen);
                    data.SetParameter("@ClienteID", encargo.Cliente.Id);
                    data.SetParameter("@VendedorID", encargo.Vendedor.Id);

                    data.ExecuteNonQuery();

                    data.SetQuery(@"DELETE FROM ArticulosEncargos WHERE EncargoId = @Id");
                    data.SetParameter("@Id", encargo.Id);
                    data.ExecuteNonQuery();


                    foreach (var item in encargo.ArticuloEncargo)
                    {
                        articulo = new Articulo()
                        {
                            Id = item.Articulo.Id,
                            Nombre = item.Articulo.Nombre,
                            Codigo = item.Articulo.Codigo,
                        };

                        long IdArticulo = articuloRepository.GetOrCreate(articulo, data);

                        if (IdArticulo == 0)
                        {
                            data.SetQuery("SELECT last_insert_rowid()");
                            IdArticulo = (long)data.ExecuteScalar();
                        }

                        data.SetQuery(@"INSERT INTO ArticulosEncargos 
                                        (ArticuloId, EncargoId, Cantidad, PrecioUnitario)
                                        VALUES
                                        (@ArticuloId, @EncargoId, @Cantidad, @PrecioUnitario)
                        ");

                        data.SetParameter("@ArticuloId", IdArticulo);
                        data.SetParameter("@EncargoId", encargo.Id);
                        data.SetParameter("@Cantidad", item.Cantidad);
                        data.SetParameter("@PrecioUnitario", item.PrecioUnitario);

                        data.ExecuteNonQuery();
                    }

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

        public void Delete(int id)
        {
            using (var data = new DataAccess())
            {
                try
                {
                    data.BeginTransaction();

                    data.SetQuery(@"DELETE FROM Encargos WHERE Id = @Id");
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
}
