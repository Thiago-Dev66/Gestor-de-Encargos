using Dominio;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class VendedorRepository
    {
        public void Add(Vendedor NewVendedor)
        {
            DataAccess data = new DataAccess(); 

			try
			{

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

        public List<Vendedor> GetAll()
        {
            List<Vendedor> lista = new List<Vendedor>();
            Vendedor aux;

            using (var data = new DataAccess())
            {
                data.SetQuery("SELECT Id, Numero, Nombre, Apellido from Vendedores");
                data.ExecuteReader();

                try
                {

                    while (data.Reader.Read())
                    {
                        aux = new Vendedor();

                        aux.Id = (int)data.Reader["Id"];
                        aux.Numero = (int)data.Reader["Numero"];
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

        public Vendedor ValidarVendedor(int val)
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

                        if (val == num)
                        {
                            vendedor = new Vendedor()
                            {
                                Id = Convert.ToInt32(data.Reader["Id"]),
                                Nombre = (string)data.Reader["Nombre"],
                                Apellido = (string)data.Reader["Apellido"]
                            };
                            return vendedor;
                        }
                    }
                    throw new NullReferenceException();
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
