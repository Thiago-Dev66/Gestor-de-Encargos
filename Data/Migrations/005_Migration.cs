using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Migrations
{
    public class _005_Migration : IMigration
    {
        public int Version => 5;
        public string MigrationName => "Add Activo column to Articulos table";

        public void Up(DataAccess data)
        {
            data.SetQuery(@"
                    ALTER TABLE Articulos 
                    ADD COLUMN Activo INTEGER NOT NULL DEFAULT 1"
            );
            data.ExecuteNonQuery();
        }
    }
}
