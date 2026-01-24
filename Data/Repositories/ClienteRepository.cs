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
        public List<Cliente> GetAll() 
        {
            DataAccess Data = new DataAccess();
            List<Cliente> clientes = new List<Cliente>();

            try
            {

                Data.SetQuery("SELECT Id, Nombre, Apellido, Celular FROM CLIENTES");
                Data.ExecuteReader();

                while (Data.Reader.Read())
                {

                    Cliente Aux = new Cliente();

                    Aux.Id = (int)Data.Reader["Id"];
                    Aux.Nombre = (string)Data.Reader["Nombre"];
                    Aux.Apellido = (string)Data.Reader["Apellido"];
                    Aux.Celular = (string)Data.Reader["Celular"];

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
                Data.ConnectionClose();
            }
        }

        public void Add(Cliente NewClient)
        {

            DataAccess data = new DataAccess();

            try
            {
               
                data.SetQuery(@"
                    INSERT INTO Clientes (Nombre, Apellido, Celular)
                    VALUES (@Nombre, @Apellido, @Celular)
                ");

                data.SetParameter("@Nombre", NewClient.Nombre);
                data.SetParameter("@Apellido", NewClient.Apellido);
                data.SetParameter("@Celular", NewClient.Celular);

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

        public void Update(Cliente Modified)
        {
            DataAccess data = new DataAccess();

            try
            {

                data.SetQuery(@"
                UPDATE Clientes SET
                    Nombre = @Nombre
                    Apellido = @Apellido
                    Celular = @Celular
                WHERE Id = @Id

                ");

                data.SetParameter("@Nombre", Modified.Nombre);
                data.SetParameter("@Apellido", Modified.Apellido);
                data.SetParameter("@Celular", Modified.Celular);
                data.SetParameter("Id", Modified.Id);

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
