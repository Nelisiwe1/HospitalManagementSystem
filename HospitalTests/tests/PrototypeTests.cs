using NUnit.Framework;
using HospitalLib;

[TestFixture]
public class PrototypeTests
{
    [Test]
    public void PrescriptionClonesSuccessfully()
    {
        var original = new AntibioticPrescription("Amoxicillin", 500);
        var clone = (AntibioticPrescription)original.Clone();

        Assert.That(clone.MedicineName, Is.EqualTo(original.MedicineName));
        Assert.That(clone.Dosage, Is.EqualTo(original.Dosage));
        Assert.That(clone, Is.Not.SameAs(original)); // Different instance
    }
}
