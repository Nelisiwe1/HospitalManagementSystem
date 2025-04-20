using NUnit.Framework;
using HospitalLib;

[TestFixture]
public class BuilderTests
{
    [Test]
    public void DiagnosisReportIsBuiltCorrectly()
    {
        var builder = new DiagnosisReportBuilder();
        var director = new ReportDirector();
        var report = director.Construct(builder);

        Assert.That(report.Header, Is.EqualTo("Diagnosis Report"));
        Assert.That(report.Body, Is.EqualTo("Patient has mild symptoms."));
        Assert.That(report.Footer, Is.EqualTo("Doctor: Dr. Smith"));
    }
}
