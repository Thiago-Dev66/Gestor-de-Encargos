using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Migrations
{
    public interface IMigration
    {
        int Version { get; }
        string MigrationName { get; }

        void Up(DataAccess data);
    }
}
