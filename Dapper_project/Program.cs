using Dapper;
using Dapper_project;
using Microsoft.Data.SqlClient;
using System.Data;

//var query = "SELECT * from [Darbuotojas]";
//var cs = "Data Source=.;Server=localhost\\SQLEXPRESS;Database=MyFirstDB;Trusted_Connection=True;TrustServerCertificate=True;";

//using var connection = new SqlConnection(cs);
//connection.Open();
//var data = connection.Query<Darbuotojas>(query);

//var query2 = "EXECUTE GetDarbuotojasByAsmensKodas @AsmensKodas";
//var spName = "[GetDarbuotojasByAsmensKodas]";

//var spParams = new { AsmensKodas = "38101122335" };
//var result = connection.QueryFirst<Darbuotojas>(query2, spParams);
//var spResult = connection.QueryFirst<Darbuotojas>(spName, spParams, commandType: CommandType.StoredProcedure);
//var query3 = "SELECT * FROM [DARBUOTOJAS]" +
//             "WHERE Vardas = @Vardas";
//var queryResult = connection.Query<Darbuotojas>(query3, new {Vardas = "Petras"});
//Console.WriteLine();

var connection = new Sql_Connection();

var SQLServer = new SQL_Services();
var darbuotojas = SQLServer.FindEmployeesByAsmensKodas("38101122335");
//SQLServer.InsertNewDarbuotojas("45805041122", "Toma", "Kucinske", new DateTime(2000,02,02), new DateTime(1984,04,04), "Programuotoja", "Testavimo", 2);
//Console.WriteLine();

var repositoryOfProjektai = new Repository<Projektas>();
var second = new Repository<Darbuotojas>();
var secondList = second.GetAllData();
var listOfProjects = repositoryOfProjektai.GetAllData();
Console.WriteLine();

connection.Dispose();



