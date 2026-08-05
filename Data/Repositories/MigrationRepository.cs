using Data.Migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data.Repositories
{
    public class MigrationRepository
    {
        public void Register(int id, string name)
        {
            using (var data = new DataAccess())
            {
                try
                {
                    data.BeginTransaction();

                    data.SetQuery("INSERT INTO Migrations (Id, MigrationName, AppliedOn) VALUES (@Id, @Name, @fecha)");
                    data.SetParameter("@Id", id);
                    data.SetParameter("@Name", name);
                    data.SetParameter("@fecha", DateTime.Now);
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
        public HashSet<int> GetAppliedMigrations()
        {
            using (var data = new DataAccess())
            {
                var migrations = new HashSet<int>();

                data.SetQuery("SELECT Id FROM Migrations");
                data.ExecuteReader();

                while (data.Reader.Read())
                {
                    if (!(data.Reader["Id"] is DBNull))
                        migrations.Add(Convert.ToInt32(data.Reader["Id"]));
                }

                return migrations;
            }
        }
    }
}
