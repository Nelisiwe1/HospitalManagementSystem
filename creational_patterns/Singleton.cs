public class DatabaseConnection
{
    private static DatabaseConnection instance;
    private static readonly object padlock = new object();

    public string ConnectionString { get; private set; }

    private DatabaseConnection()
    {
        ConnectionString = "Server=localhost;Database=HospitalDB;";
    }

    public static DatabaseConnection Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                    instance = new DatabaseConnection();
                return instance;
            }
        }
    }
}