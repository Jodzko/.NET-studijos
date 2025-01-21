using Dapper;
using Microsoft.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace Dapper_project
{
    public class SQL_Services
    {
        public SQL_Services()
        {
                     
        }
        

        public Darbuotojas FindEmployeesByAsmensKodas(string asmensKodas)
        {        
            var query = "[GetDarbuotojasByAsmensKodas]";
            var newParameter = new { AsmensKodas = asmensKodas };
            var result = Sql_Connection.sqlConnection.QueryFirst<Darbuotojas>(query, newParameter, commandType: CommandType.StoredProcedure);
            return result;
        }

        public void InsertNewDarbuotojas(string ak, string vardas, string pavarde, DateTime nuokada, DateTime gimimoMetai, string pareigos, string skyrius, int projektas)
        {
            var query = "[InsertNewDarbuotojas]";
            var parameters = new { AsmensKodas = ak, Vardas = vardas, Pavarde = pavarde, Nuokada = nuokada, GimimoMetai = gimimoMetai, Pareigos = pareigos, Skyrius_pavadinimas = skyrius, Projektas_Id = projektas };
            var result = Sql_Connection.sqlConnection.Query<Darbuotojas>(query, parameters);
            Console.WriteLine();
        }

    }
}
