namespace FactoryMethod.DatabaseContext;

public interface IDatabase
{
    void Connect();
    void ExecuteQuery(string query);
}