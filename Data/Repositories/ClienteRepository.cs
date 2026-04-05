using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Dominio;

namespace Data.Repositories
{
    public class ClienteRepository
    {
        public List<Cliente> GetAll(DataAccess data = null)
        {
            List<Cliente> clientes = new List<Cliente>();
            bool shouldDispose = data == null;
            data = data ?? new DataAccess();
            //nullish coalescing operator.
            //Se utiliza para proporcionar un valor predeterminado
            //cuando una variable es null o undefined

            using (data)
            {
                try
                {
                    data.SetQuery("SELECT Id, Nombre, Apellido, Celular FROM CLIENTES");
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

                    return clientes;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (shouldDispose)
                        data.Dispose();
                }
            }
        }

        public Cliente Existente(Cliente cliente, DataAccess data)
        {
            var clientes = new List<Cliente>();
            Cliente cli;

            try
            {
                using (data)
                {
                    clientes = GetAll();
                    return cli = clientes.FirstOrDefault(c => c.Celular == cliente.Celular);
                }
            }
            catch (Exception)
            {
                throw;
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
            DataAccess data = new DataAccess();

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

        public void Delete(int id)
        {
            DataAccess data = new DataAccess();

            try
            {

                data.SetQuery("DELETE FROM Clientes WHERE Id = @Id");
                data.SetParameter("@Id", id);

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
}
