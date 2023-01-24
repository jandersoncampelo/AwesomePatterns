namespace FactoryMethod.DatabaseContext;

public class SqlServer : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connecting to Sql Server...");
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine("Executing query on Sql Server: " + query);
    }
}