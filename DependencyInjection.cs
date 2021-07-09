//no Dependency Injection
public class Service
{
    private readonly IDatabase database;
    public Service()
    {
        database = new SqlDatabase();
    }
}

// Dependency Injection
public class Service
{
    private readonly IDatabase database;
    public Service(IDatabase database)
    {
        this.database = database;
    }
}