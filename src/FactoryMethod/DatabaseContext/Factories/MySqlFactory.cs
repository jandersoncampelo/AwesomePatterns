namespace FactoryMethod.DatabaseContext;

public class MySqlFactory : DatabaseFactory
{
    public override IDatabase CreateDatabase()
    {
        return new MySql();
    }
}