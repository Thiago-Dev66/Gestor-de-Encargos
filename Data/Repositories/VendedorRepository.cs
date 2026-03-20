using Dominio;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Data.Repositories
{
    public class VendedorRepository
    {
        public void Add(Vendedor NewVendedor)
        {
            using (var data = new DataAccess())
            {
                bool existent;

                try
                {
                    existent = VendedorExistente(NewVendedor, data);

                    if (existent)
                        throw new Exception("El vendedor ya existe");

                    data.SetQuery(@"
                        INSERT INTO Vendedores (Numero, Nombre, Apellido)
                        VALUES (@Numero, @Nombre, @Apellido)
                        ");

                    data.SetParameter("@Numero", NewVendedor.Numero);
                    data.SetParameter("@Nombre", NewVendedor.Nombre);
                    data.SetParameter("@Apellido", NewVendedor.Apellido);

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
        public bool VendedorExistente(Vendedor vendedor, DataAccess data)
        {
            List<Vendedor> vendedores = GetAll(data);

            try
            {
                foreach (var item in vendedores)
                {
                    if (item.Numero == vendedor.Numero)
                        return true;
                }
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<Vendedor> GetAll(DataAccess data = null)
        {
            List<Vendedor> lista = new List<Vendedor>();
            Vendedor aux;

            data = data ?? new DataAccess();

            using (data)
            {
                data.SetQuery("SELECT Id, Numero, Nombre, Apellido from Vendedores");
                data.ExecuteReader();

                try
                {
                    while (data.Reader.Read())
                    {
                        aux = new Vendedor();

                        aux.Id = Convert.ToInt32(data.Reader["Id"]);
                        aux.Numero = Convert.ToInt32(data.Reader["Numero"]);
                        aux.Nombre = (string)data.Reader["Nombre"];
                        aux.Apellido = (string)data.Reader["Apellido"];

                        lista.Add(aux);

                    }

                    return lista;

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

        public void Update(Vendedor Modified)
        {
            DataAccess data = new DataAccess();

            try
            {

                data.SetQuery(@"
                        UPDATE Vendedores SET
                            Numero = @Numero,
                            Nombre = @Nombre,
                            Apellido = @Apellido
                        WHERE Id = @Id
                     
                ");

                data.SetParameter("@id", Modified.Id);
                data.SetParameter("@Numero", Modified.Numero);
                data.SetParameter("@Nombre", Modified.Nombre);
                data.SetParameter("@Apellido", Modified.Apellido);

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

                data.SetQuery("DELETE FROM Vendedores WHERE Id = @Id");
                data.SetParameter("@id", id);

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

        public Vendedor Validar(int number)
        {
            Vendedor vendedor;
            int num;

            using (var data = new DataAccess())
            {
                try
                {
                    data.SetQuery("SELECT Id, Numero, Nombre, Apellido FROM Vendedores");
                    data.ExecuteReader();

                    while (data.Reader.Read())
                    {
                        num = Convert.ToInt32(data.Reader["Numero"]);

                        if (number == num)
                        {
                            vendedor = new Vendedor()
                            {
                                Id = Convert.ToInt32(data.Reader["Id"]),
                                Numero = Convert.ToInt32(data.Reader["Numero"]),
                                Nombre = (string)data.Reader["Nombre"],
                                Apellido = (string)data.Reader["Apellido"]
                            };
                            return vendedor;
                        }
                    }
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
    }
}
