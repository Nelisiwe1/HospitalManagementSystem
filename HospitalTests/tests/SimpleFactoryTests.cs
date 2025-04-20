using NUnit.Framework;

[TestFixture]
public class SimpleFactoryTests
{
    [Test]
    public void CreateGeneralPatientTest()
    {
        var patient = PatientFactory.CreatePatient("General");
        Assert.That(patient.Name, Is.EqualTo("John Doe"));

    }

    [Test]
    public void InvalidTypeThrowsError()
    {
        Assert.Throws<ArgumentException>(() => PatientFactory.CreatePatient("Alien"));
    }
}