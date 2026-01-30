using System;
using System.Collections.Generic;
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

            DataAccess data = new DataAccess();

            try
            {

                data.BeginTransaction();

                data.SetQuery(@"
                        INSERT INTO Encargos 
                        (Fecha, Estado, Descripcion, SucursalOrigen, ClienteId, VendedorId)
                        VALUES 
                        (@Fecha, @Estado, @Descripcion, @SucursalOrigen, @ClienteId, @VendedorId)
                        SELECT last_insert_rowid();
                ");

                data.SetParameter("@Fecha", encargo.Fecha);
                data.SetParameter("@Estado", (int)encargo.Estado);
                data.SetParameter("@Descripcion", encargo.Descripcion);
                data.SetParameter("@SucursalOrigen", encargo.SucursalOrigen);
                data.SetParameter("@ClienteId", encargo.Cliente.Id);
                data.SetParameter("@VendedorId", encargo.Vendedor.Id);

                int encargoId = (int)data.ExecuteScalar();

                foreach (var item in encargo.ArticuloEncargo)
                {
                    data.SetQuery(@"
                            INSERT INTO ArticulosEncargos 
                                (ArticuloId, EncargoId, Cantidad, PrecioUnitario)
                            VALUES
                                (@ArticuloId, @EncargoId, @Cantidad, @PrecioUnitario)
                    ");

                    data.SetParameter("@ArticuloId", item.ArticuloID);
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

        public List<Encargo> GetAll()
        {
            Encargo encargo;
            List<Encargo> encargos = new List<Encargo>();
            DataAccess data = new DataAccess();

            try
            {

                data.SetQuery(@"
                    SELECT E.Fecha, E.Estado, E.Descripcion, E.SucursalOrigen, E.ClienteID, E.VendedorID
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

                    encargo.Fecha = DateTime.Parse(data.Reader["Fecha"].ToString());
                    encargo.Estado = (EstadoEncargo)data.Reader["Estado"];
                    encargo.Descripcion = (string)data.Reader["Descripcion"];
                    encargo.SucursalOrigen = (string)data.Reader["SucursalOrigen"];
                    encargo.Cliente.Id = (int)data.Reader["ClienteID"];
                    encargo.Vendedor.Id = (int)data.Reader["VendedorId"];

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

        public void Update(Encargo encargo)
        {
            DataAccess data = new DataAccess();

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
                    data.SetQuery(@"INSERT INTO ArticulosEncargos 
                                        (ArticuloId, EncargoId, Cantidad, PrecioUnitario)
                                    VALUES
                                        (@ArticuloId, @EncargoId, @Cantidad, @PrecioUnitario)
                    ");

                    data.SetParameter("@ArticuloId", item.ArticuloID);
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

        public void Delete(int id)
        {
            DataAccess data = new DataAccess();

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
