
namespace Data.Migrations
{
    public class _004_Migration : IMigration
    {
        public int Version => 4;
        public string MigrationName => "AddColumnActivoToEncargos";

        public void Up(DataAccess data)
        {
            data.SetQuery(@"ALTER TABLE Encargos 
                            ADD COLUMN Activo INTEGER NOT NULL DEFAULT 1
            ");
            data.ExecuteNonQuery();
        }
    }
}
