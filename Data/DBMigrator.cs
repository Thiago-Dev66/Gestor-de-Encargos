using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Migrations;

namespace Data
{
    public static class DBMigrator
    {
        public static void Migrate(DataAccess data)
        {
            var migration = new _002_Migration();

            migration.Up(data);
        }
    }
}
