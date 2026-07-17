using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;
using Dominio.Interfaces;

namespace Data.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        public List<Cliente> GetAll()
        {
            var clientes = new List<Cliente>();

            using (var data = new DataAccess())
            {
                try
                {
                    data.BeginTransaction();

                    data.SetQuery("SELECT Id, Nombre, Apellido, Celular FROM CLIENTES WHERE Activo = 1");
                    data.ExecuteReader();

                    while (data.Reader.Read())
                    {
                        Cliente Aux = new Cliente();

                        Aux.Id = Convert.ToInt32(data.Reader["Id"]);
                        Aux.Nombre = (string)data.Reader["Nombre"];
                        Aux.Apellido = (string)data.Reader["Apellido"];
                        Aux.Celular = (string)data.Reader["Celular"];

                        clientes.Add(Aux);
                    }

                    data.Commit();
                    return clientes;
                }
                catch (Exception exc)
                {
                    data.Rollback();
                    throw new Exception("Error al obtener Clientes", exc);
                }
                finally
                {
                    data.Dispose();
                }
            }
        }

        private Cliente Existente(Cliente cliente, DataAccess data)
        {
            var clientes = new List<Cliente>();

            try
            {
                return cliente = GetAll()
                    .FirstOrDefault(c => c.Celular == cliente.Celular);
            }
            catch (Exception exc)
            {
                throw new Exception("Cliente no encontrado", exc);
            }
        }

        public Cliente Add(Cliente NewClient)
        {
            using (var data = new DataAccess())
            {
                try
                {
                    Cliente cliente = Existente(NewClient, data);

                    if (cliente != null)
                        return cliente;

                    data.SetQuery(@"
                            INSERT INTO Clientes (Nombre, Apellido, Celular)
                            VALUES (@Nombre, @Apellido, @Celular)
                            ");

                    data.SetParameter("@Nombre", NewClient.Nombre);
                    data.SetParameter("@Apellido", NewClient.Apellido);
                    data.SetParameter("@Celular", NewClient.Celular);

                    data.ExecuteNonQuery();

                    return null;
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

        public void Update(Cliente Modified)
        {
            using (var data = new DataAccess())
            {
                try
                {

                    data.SetQuery(@"
                        UPDATE Clientes SET
                            Nombre = @Nombre,
                            Apellido = @Apellido,
                            Celular = @Celular
                        WHERE Id = @Id

                        ");

                    data.SetParameter("@Nombre", Modified.Nombre);
                    data.SetParameter("@Apellido", Modified.Apellido);
                    data.SetParameter("@Celular", Modified.Celular);
                    data.SetParameter("@Id", Modified.Id);

                    data.ExecuteNonQuery();
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

        public void Delete(int id)
        {
            DataAccess data = new DataAccess();

            try
            {
                data.SetQuery(@"UPDATE Clientes 
                                SET Activo = 0 
                                WHERE Id = @Id");

                data.SetParameter("@Id", id);
                data.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw new Exception(exc.ToString());
            }
            finally
            {
                data.ConnectionClose();
            }
        }
    }
}
