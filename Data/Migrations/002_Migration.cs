namespace Data.Migrations
{
    public class _002_Migration : IMigration
    {
        public int Version => 2;
        public string MigrationName => "Add Activo column to Vendedores table";
        
        public void Up(DataAccess data)
        {
            data.SetQuery(@"
                    ALTER TABLE Vendedores 
                    ADD COLUMN Activo INTEGER NOT NULL DEFAULT 1"
            );
            data.ExecuteNonQuery();
        }
    }
}