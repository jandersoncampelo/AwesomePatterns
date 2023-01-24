namespace FactoryMethod.DatabaseContext;

public abstract class DatabaseFactory
{
    public abstract IDatabase CreateDatabase();
}