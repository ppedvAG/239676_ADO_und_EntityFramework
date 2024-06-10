using HalloDatenbank;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.Diagnostics;


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

        Console.WriteLine("Alle Employees aus DB:");
        var emps = GetEmployees(con).ToList();
        ShowEmployees(emps);

        foreach (var emp in emps)
        {
            emp.BirthDate = emp.BirthDate.AddYears(1);
        }

        Console.WriteLine("Alle Employees 1 Jahr jünger:");
        ShowEmployees(emps);

        var trans = con.BeginTransaction();
        try
        {
            foreach (var emp in emps)
            {
                if (emp.FirstName == "Steven")
                    throw new OutOfMemoryException();

                var updCmd = con.CreateCommand();
                updCmd.Transaction = trans;

                updCmd.CommandText = "UPDATE Employees SET BirthDate = @newBDate WHERE EmployeeId = @id";
                updCmd.Parameters.AddWithValue("@newBDate", emp.BirthDate);
                updCmd.Parameters.AddWithValue("@id", emp.Id);
                var rowAffected = updCmd.ExecuteNonQuery();
                Console.WriteLine($"Updated {emp.FirstName}: {rowAffected} ");
            }
            trans.Commit();
            Console.WriteLine("All fine, transaction commited");
        }
        catch (Exception ex)
        {
            trans.Rollback();
            Console.WriteLine($"ERR: {ex.Message} \n\n-> transaction rolled back");
        }


        Console.WriteLine("Suche:");
        var suche = Console.ReadLine();
        //erstelle aus den folgenden Block eine Methode (ShowEmployees) und als die suche als optionalen Parameter

        emps = GetEmployees(con, suche).ToList();
        ShowEmployees(emps);

        Console.WriteLine("Ende");
        Console.ReadLine();

    }

    static void ShowEmployees(IEnumerable<Employee> employees)
    {
        foreach (var emp in employees)
        {
            Console.WriteLine($"[{emp.Id}] {emp.FirstName} {emp.LastName} {emp.BirthDate:d}");
        }
    }

    static IEnumerable<Employee> GetEmployees(SqlConnection con, string? suche = "")
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
                var id = reader.GetInt32(reader.GetOrdinal("EmployeeId"));
                yield return new Employee
                {
                    Id = id,
                    FirstName = firstName,
                    LastName = lastName,
                    BirthDate = birthDate,
                };
            }
        }
    }
}
