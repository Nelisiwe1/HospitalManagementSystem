using NUnit.Framework;

[TestFixture]
public class SimpleFactoryTests
{
    [Test]
    public void CreateGeneralPatientTest()
    {
        var patient = PatientFactory.CreatePatient("General");
        Assert.AreEqual("John Doe", patient.Name);
    }

    [Test]
    public void InvalidTypeThrowsError()
    {
        Assert.Throws<ArgumentException>(() => PatientFactory.CreatePatient("Alien"));
    }
}