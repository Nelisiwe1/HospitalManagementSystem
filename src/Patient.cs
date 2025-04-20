public class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Diagnosis { get; set; }

    public Patient(int id, string name, string diagnosis)
    {
        Id = id;
        Name = name;
        Diagnosis = diagnosis;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"{Name} (ID: {Id}) - {Diagnosis}");
    }
}