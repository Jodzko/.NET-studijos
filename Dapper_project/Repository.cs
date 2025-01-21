using Dapper;
using Microsoft.Data.SqlClient;

namespace Dapper_project
{
    public class Repository<T>
    {
        public Repository()
        {
            
        }
        public List<T> GetAllData()
        {
            var connection = new SqlConnection("Data Source=.;Server=localhost\\SQLEXPRESS;Database=MyFirstDB;Trusted_Connection=True;TrustServerCertificate=True;");
            var query = $"SELECT * FROM {typeof(T).Name}";
            var result = connection.Query<T>(query);
            return result.ToList();
        }
    }
}
