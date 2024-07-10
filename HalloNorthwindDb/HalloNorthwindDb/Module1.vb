Imports System.Data.SqlClient
Imports System.Text

Module Module1

    Sub Main()
        Console.OutputEncoding = Encoding.UTF8
        Console.WriteLine("*** Hallo DB 🚲🦽 ***")

        Dim sqlConString = "Server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=True;"
        sqlConString = "Server=(localdb)\mssqllocaldb;Database=NORTHWND;Trusted_Connection=true;TrustServerCertificate=True;"

        Try
            Dim con = New SqlConnection(sqlConString)
            con.Open()
            Console.WriteLine("DB Connection OK")

            'Dim cmd As SqlCommand = New SqlCommand()
            'cmd.Connection = con
            Dim cmd As SqlCommand = con.CreateCommand()
            cmd.CommandText = "SELECT COUNT(*) FROM Employees"
            Dim empCount = cmd.ExecuteScalar()
            Console.WriteLine($"{empCount} Employees in DB")

            cmd = con.CreateCommand()
            cmd.CommandText = "SELECT * FROM Employees ORDER BY FirstName"
            Dim reader = cmd.ExecuteReader()
            While reader.Read()

                Dim lastName As String = reader("LastName").ToString()
                Dim firstName As String = reader.GetString(2)
                Dim birthDate As DateTime = reader.GetDateTime(reader.GetOrdinal("BirthDate"))

                Console.WriteLine($"Name: {firstName} {lastName} {birthDate:d}")

            End While

            con.Close()

        Catch sex As SqlException
            Console.WriteLine($"SQL EX: {sex.Message}")
        Catch ex As Exception
            Console.WriteLine($"Schade: {ex.Message}")
        End Try

        Console.WriteLine("Ende gelände")
        Console.ReadKey()
    End Sub

End Module
