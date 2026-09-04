
namespace Data.Migrations
{
    public class _006_Migration : IMigration
    {
        public int Version => 6;
        public string MigrationName => "AddColumnEmailToClientes";

        public void Up(DataAccess data)
        {
            data.SetQuery(@"
                    ALTER TABLE Clientes 
                    ADD COLUMN Email TEXT NULL;
            ");
            data.ExecuteNonQuery();
        }
    }
}