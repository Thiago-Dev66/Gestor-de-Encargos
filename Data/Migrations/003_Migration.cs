using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Migrations
{
    public class _003_Migration : IMigration
    {
        public int Version => 3;
        public string MigrationName => "AddNewTable";

        public void Up(DataAccess data)
        {
            try
            {
                data.BeginTransaction();

                data.SetQuery(@"
                    CREATE TABLE IF NOT EXISTS Migrations (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        MigrationName TEXT NOT NULL UNIQUE,
                        AppliedOn Text NOT NULL
                    );"
                );
                data.ExecuteNonQuery();

                data.Commit();
            }
            catch (Exception)
            {
                data.Rollback();
            }
            finally
            {
                data.ConnectionClose();
            }
        }
    }
}