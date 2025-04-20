public class MedicalReport
{
    public string Header { get; set; }
    public string Body { get; set; }
    public string Footer { get; set; }

    public void ShowReport()
    {
        Console.WriteLine($"{Header}\n{Body}\n{Footer}");
    }
}

public abstract class ReportBuilder
{
    protected MedicalReport report = new MedicalReport();
    public abstract void BuildHeader();
    public abstract void BuildBody();
    public abstract void BuildFooter();
    public MedicalReport GetReport() => report;
}

public class DiagnosisReportBuilder : ReportBuilder
{
    public override void BuildHeader() => report.Header = "Diagnosis Report";
    public override void BuildBody() => report.Body = "Patient has mild symptoms.";
    public override void BuildFooter() => report.Footer = "Doctor: Dr. Smith";
}

public class ReportDirector
{
    public MedicalReport Construct(ReportBuilder builder)
    {
        builder.BuildHeader();
        builder.BuildBody();
        builder.BuildFooter();
        return builder.GetReport();
    }
}