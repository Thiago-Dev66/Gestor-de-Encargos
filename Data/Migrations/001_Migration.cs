using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Migrations
{
    public class _001_Migration : IMigration
    {
        public int Version => 1;
        public string MigrationName => "Add Activo column to Clientes table";

        public void Up(DataAccess data) 
        {
            data.SetQuery(@"
                    ALTER TABLE Clientes 
                    ADD COLUMN Activo INTEGER NOT NULL DEFAULT 1"
            );
            data.ExecuteNonQuery();
        }
    }
}
