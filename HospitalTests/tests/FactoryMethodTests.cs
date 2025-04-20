using NUnit.Framework;
using HospitalLib;

[TestFixture]
public class FactoryMethodTests
{
    [Test]
    public void EmailFactoryCreatesEmailNotification()
    {
        NotificationFactory factory = new EmailFactory();
        var notification = factory.CreateNotification();
        Assert.That(notification, Is.InstanceOf<EmailNotification>());
    }

    [Test]
    public void SmsFactoryCreatesSmsNotification()
    {
        NotificationFactory factory = new SmsFactory();
        var notification = factory.CreateNotification();
        Assert.That(notification, Is.InstanceOf<SmsNotification>());
    }
}
