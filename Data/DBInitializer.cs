using Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DBInitializer
    {
        public static void Initialization()
        {
            try
            {
                using (var Access = new DataAccess())
                {
                    if (Directory.Exists(DataPathManager.AppDataFolder))
                    {
                        CreateTableMigrations(Access);
                        DBMigrator.Migrate(Access);
                    }

                    CreateTableClientes(Access);
                    CreateTableVendedores(Access);
                    CreateTableEncargos(Access);
                    CreateTableArticulos(Access);
                    CreateTableArticulosEncargos(Access);
                    CreateTableMigrations(Access);
                }
                ;
                if (!File.Exists(DataPathManager.GetConfiguracionPath()))
                    CreateConfigFile(DataPathManager.GetConfiguracionPath());
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al inicializar base de datos {ex.Message}");
            }
        }

        public static void CreateConfigFile(string path)
        {
            var builder = new StringBuilder();

            builder.AppendLine("Hola, {ClienteNombre}! Te habla {VendedorNombre}");
            builder.AppendLine("Tu pedido ya está listo para retirar:");
            builder.AppendLine("    • {Articulos}");
            builder.AppendLine();
            builder.Append("Te esperamos!");

            var config = new Configuracion()
            {
                MensajeEncargo = builder.ToString()
            };

            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText(path, json);
        }

        public static void CreateTableClientes(DataAccess Access)
        {

            try
            {
                Access.SetQuery(@"
                    CREATE TABLE IF NOT EXISTS Clientes (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Nombre TEXT NOT NULL,
                        Apellido TEXT,
                        Celular TEXT NOT NULL,
                        Activo INTEGER NOT NULL DEFAULT 1
                    );"
                );
                Access.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Access.ConnectionClose();
            }
        }

        public static void CreateTableVendedores(DataAccess Access)
        {
            try
            {
                Access.SetQuery(@"
                    CREATE TABLE IF NOT EXISTS Vendedores (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Numero INTEGER NOT NULL UNIQUE,
                        Nombre TEXT NOT NULL,
                        Apellido TEXT NOT NULL,
                        Activo INTEGER NOT NULL DEFAULT 1
                    );"
                );

                Access.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { Access.ConnectionClose(); }
        }

        public static void CreateTableEncargos(DataAccess Access)
        {
            try
            {
                Access.SetQuery(@"
                    CREATE TABLE IF NOT EXISTS Encargos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Fecha TEXT NOT NULL,
                        Estado INTEGER NOT NULL DEFAULT 0,
                        Descripcion TEXT,
                        SucursalOrigen TEXT NOT NULL,
                        Activo INTEGER NOT NULL DEFAULT 1,
                        ClienteID INTEGER NOT NULL,
                        VendedorID INTEGER NOT NULL,
                    
                        FOREIGN KEY (ClienteID) REFERENCES Clientes(Id)
                        ON DELETE RESTRICT
                        ON UPDATE CASCADE,

                        FOREIGN KEY (VendedorID) REFERENCES Vendedores(Id)
                        ON DELETE RESTRICT
                        ON UPDATE CASCADE
                     
                    );"
                );

                Access.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { Access.ConnectionClose(); }
        }

        public static void CreateTableArticulos(DataAccess Access)
        {
            try
            {
                Access.SetQuery(@"
                    CREATE TABLE IF NOT EXISTS Articulos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Codigo TEXT NOT NULL UNIQUE,
                        Nombre TEXT NOT NULL,
                        Precio REAL
                        Activo INTEGER NOT NULL DEFAULT 1
                    );"
                );

                Access.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { Access.ConnectionClose(); }
        }

        public static void CreateTableArticulosEncargos(DataAccess Access)
        {
            try
            {
                Access.SetQuery(@"
                    CREATE TABLE IF NOT EXISTS ArticulosEncargos (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        ArticuloID INTEGER NOT NULL,
                        EncargoID INTEGER NOT NULL,
                        Cantidad INTEGER NOT NULL DEFAULT 1,
                        PrecioUnitario REAL,
            
                        FOREIGN KEY (ArticuloID) REFERENCES Articulos(Id)
                        ON DELETE RESTRICT
                        ON UPDATE CASCADE, 

                        FOREIGN KEY (EncargoID) REFERENCES Encargos(Id)
                        ON DELETE RESTRICT
                        ON UPDATE CASCADE

                    );"

                );

                Access.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally { Access.ConnectionClose(); }
        }
        public static void CreateTableMigrations(DataAccess access)
        {
            try
            {
                access.SetQuery(@"
                    CREATE TABLE IF NOT EXISTS Migrations (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        MigrationName TEXT NOT NULL UNIQUE,
                        AppliedOn Text NOT NULL
                    );"
                );
                access.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                throw new Exception("Error al crear la tabla 'Migrations'", exc);
            }
            finally
            {
                access.ConnectionClose();
            }
        }
    }
}
