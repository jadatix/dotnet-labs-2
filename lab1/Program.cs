using System.Data.SqlClient;

class Program
{
    static async Task Main(string[] args)
    {
        string connectionString = "Server=localhost;Database=TradesOperations;User Id=SA;Password=Password123!;TrustServerCertificate=True;";

        using SqlConnection connection = new(connectionString);
        await connection.OpenAsync();

        string query = "SELECT * FROM Sales JOIN Companies ON Sales.CompanyId = Companies.CompanyId JOIN Products ON Sales.ProductId = Products.ProductId";

        SqlCommand command = new(query, connection);

        using SqlDataReader reader = await command.ExecuteReaderAsync();
        while (await reader.ReadAsync())
        {
            Console.WriteLine($"Company: {reader["Name"]}, Product: {reader["Name"]}, Date of Sale: {reader["DateOfSale"]}");
        }
    }
}
