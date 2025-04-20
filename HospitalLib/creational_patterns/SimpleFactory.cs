public static class PatientFactory
{
    public static Patient CreatePatient(string type)
    {
        return type switch
        {
            "General" => new Patient(1, "John Doe", "Flu"),
            "Emergency" => new Patient(2, "Jane Smith", "Accident"),
            _ => throw new ArgumentException("Invalid patient type")
        };
    }
}