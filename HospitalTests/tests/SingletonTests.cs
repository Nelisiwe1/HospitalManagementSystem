using NUnit.Framework;
using HospitalLib;

[TestFixture]
public class SingletonTests
{
    [Test]
    public void DatabaseConnectionReturnsSameInstance()
    {
        var conn1 = DatabaseConnection.Instance;
        var conn2 = DatabaseConnection.Instance;

        Assert.That(conn1, Is.SameAs(conn2));
    }

    [Test]
    public void ConnectionStringIsCorrect()
    {
        var conn = DatabaseConnection.Instance;
        Assert.That(conn.ConnectionString, Is.EqualTo("Server=localhost;Database=HospitalDB;"));
    }
}
