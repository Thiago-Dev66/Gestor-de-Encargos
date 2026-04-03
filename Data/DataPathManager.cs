using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public static class DataPathManager
    {
        private static readonly string AppDataPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "Gestor de Encargos"
        );

        public static string GetDatabasePath()
        {
            if (!Directory.Exists(AppDataPath))
                Directory.CreateDirectory(AppDataPath);

            return Path.Combine(AppDataPath, "GestorEncargos.db");
        }

        public static string GetConnectionString()
        {
            string dbPath = GetDatabasePath();
            return $"Data Source={dbPath}";
        }

        public static string AppDataFolder => AppDataPath;
    }
}
