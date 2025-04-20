using NUnit.Framework;
using HospitalLib;

[TestFixture]
public class AbstractFactoryTests
{
    [Test]
    public void PediatricFactoryCreatesCorrectDoctorAndNurse()
    {
        IStaffFactory factory = new PediatricStaffFactory();
        var doctor = factory.CreateDoctor();
        var nurse = factory.CreateNurse();

        Assert.That(doctor.GetSpecialization(), Is.EqualTo("Pediatrics"));
        Assert.That(nurse.GetDepartment(), Is.EqualTo("Child Care"));
    }
}
