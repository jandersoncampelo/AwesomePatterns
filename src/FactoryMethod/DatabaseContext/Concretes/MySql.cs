namespace FactoryMethod.DatabaseContext;

public class MySql : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connecting to MySql...");
    }

    public void ExecuteQuery(string query)
    {
        Console.WriteLine("Executing query on MySql: " + query);
    }
}