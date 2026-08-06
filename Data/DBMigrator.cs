using Data.Migrations;
using Data.Repositories;
using Dominio;
using System.Collections.Generic;
using System.Reflection;

namespace Data
{
    public static class DBMigrator
    {
        private static List<IMigration> Migraciones => new List<IMigration>
        {
            new _001_Migration(),
            new _002_Migration(),
            new _003_Migration(),
            new _004_Migration(),
            new _005_Migration(),
        };

        public static void Migrate(DataAccess data)
        {
            var repository = new MigrationRepository();
            HashSet<int> appliedMigrations = repository.GetAppliedMigrations();

            foreach (IMigration migration in Migraciones)
            {
                if (!appliedMigrations.Contains(migration.Version))
                {
                    migration.Up(data);
                    repository.Register(migration.Version, migration.MigrationName);
                }
            }
        }
    }
}