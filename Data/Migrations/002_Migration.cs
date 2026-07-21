namespace Data.Migrations
{
    public class _002_Migration
    {
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