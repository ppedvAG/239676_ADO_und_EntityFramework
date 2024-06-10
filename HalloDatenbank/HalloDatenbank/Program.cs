using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Hello Datebank ***");
        //string conString = "Server=(localdb)\\mssqllocaldb;Database=Northwnd;Trusted_Connection=true;TrustServerCertificate=true;";

        var builder = new ConfigurationBuilder()
                          .AddJsonFile("appsettings.json")
                          //.AddUserSecrets<Program>();
                          .AddUserSecrets("d458d5dc-942e-4365-8652-14a8f88afbfd");

        var config = builder.Build();

        var conString = config.GetConnectionString("DefaultConnection");
        //var conString = config.GetSection("ConnectionStrings").GetSection("DefaultConnection").Value;

        if (Enum.TryParse<ConsoleColor>(config.GetSection("FontColor").Value, out var configColor))
            Console.ForegroundColor = configColor;

        using var con = new SqlConnection(conString);

        con.Open();
        Console.WriteLine("Datenbankverbindung wurde hergestellt");

        using (var cmd = con.CreateCommand())
        {
            cmd.CommandText = "SELECT COUNT(*) FROM Employees";
            var empCount = cmd.ExecuteScalar();
            Console.WriteLine($"{empCount} Employees in DB");
        }

        ShowEmployees(con);

        Console.WriteLine("Suche:");
        var suche = Console.ReadLine();
        //erstelle aus den folgenden Block eine Methode (ShowEmployees) und als die suche als optionalen Parameter

        ShowEmployees(con, suche);

        Console.WriteLine("Ende");
        Console.ReadLine();

    }

    static void ShowEmployees(SqlConnection con, string? suche = "")
    {
        using (var cmd = con.CreateCommand())
        {
            //cmd.CommandText = "SELECT * FROM Employees WHERE FirstName LIKE '" + suche + "%'"; //BÖSE => SQL INJECTION!!!
            cmd.CommandText = "SELECT * FROM Employees WHERE FirstName LIKE @search";
            cmd.Parameters.AddWithValue("@search", suche + "%");

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var firstName = reader.GetString(reader.GetOrdinal("FirstName"));
                var lastName = reader.GetString(reader.GetOrdinal("LastName"));
                var birthDate = reader.GetDateTime(reader.GetOrdinal("BirthDate"));
                Console.WriteLine($"{firstName} {lastName} {birthDate:d}");
            }
        }
    }
}