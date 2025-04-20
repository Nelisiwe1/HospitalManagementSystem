public interface INotification
{
    void Send(string message);
}

public class EmailNotification : INotification
{
    public void Send(string message) => Console.WriteLine("Email sent: " + message);
}

public class SmsNotification : INotification
{
    public void Send(string message) => Console.WriteLine("SMS sent: " + message);
}

public abstract class NotificationFactory
{
    public abstract INotification CreateNotification();
}

public class EmailFactory : NotificationFactory
{
    public override INotification CreateNotification() => new EmailNotification();
}

public class SmsFactory : NotificationFactory
{
    public override INotification CreateNotification() => new SmsNotification();
}