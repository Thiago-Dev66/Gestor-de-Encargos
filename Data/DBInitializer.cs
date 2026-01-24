using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DBInitializer
    {

        public static void Initialization()
        {

            DataAccess Access = new DataAccess();

            CreateTableClientes(Access);
            CreateTableVendedores(Access);
            CreateTableEncargos(Access);
            CreateTableArticulos(Access);
            CreateTableArticulosEncargos(Access);

        }

        public static void CreateTableClientes(DataAccess Access)
        {

            Access.SetQuery(@"
            
                CREATE TABLE IF NOT EXISTS Clientes (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Nombre TEXT NOT NULL,
                    Apellido TEXT,
                    Celular TEXT NOT NULL

                );"

            );

            Access.ExecuteNonQuery();

        }

        public static void CreateTableVendedores(DataAccess Access)
        {
            Access.SetQuery(@"

                CREATE TABLE IF NOT EXISTS Vendedores (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Numero INTEGER NOT NULL UNIQUE,
                    Nombre TEXT NOT NULL,
                    Apellido TEXT NOT NULL

                );"
            );

            Access.ExecuteNonQuery();
        }

        public static void CreateTableEncargos(DataAccess Access)
        {
            Access.SetQuery(@"

                CREATE TABLE IF NOT EXISTS Encargos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Fecha TEXT NOT NULL,
                    Estado INTEGER NOT NULL DEFAULT 0,
                    Descripcion TEXT,
                    SucursalOrigen TEXT NOT NULL,
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

        public static void CreateTableArticulos(DataAccess Access)
        {
            Access.SetQuery(@"

                CREATE TABLE IF NOT EXISTS Articulos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Codigo INTEGER NOT NULL UNIQUE,
                    Nombre TEXT,
                    Precio REAL
                    
                );"
            );

            Access.ExecuteNonQuery();
        }

        public static void CreateTableArticulosEncargos(DataAccess Access)
        {
            Access.SetQuery(@"
    
                CREATE TABLE IF NOT EXISTS ArticulosEncargos (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ArticuloID INTEGER NOT NULL,
                    EncargoID INTEGER NOT NULL,
                    Cantidad INTEGER NOT NULL DEFAULT 1,
                    PrecioUnitario REAL NOT NULL,
            
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
    }
}
