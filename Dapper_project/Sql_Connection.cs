using Microsoft.Data.SqlClient;

namespace Dapper_project
{
    public class Sql_Connection : IDisposable
    {

        private static readonly string cs = "Data Source=.;Server=localhost\\SQLEXPRESS;Database=MyFirstDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public static SqlConnection sqlConnection;

        public Sql_Connection()
        {
            sqlConnection = new SqlConnection(cs);
            sqlConnection.Open();
        }

        public void Dispose()
        {
            sqlConnection.Dispose();
        }
    }
}
