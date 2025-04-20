public class Appointment
{
    public Patient Patient { get; set; }
    public Doctor Doctor { get; set; }
    public DateTime Date { get; set; }

    public Appointment(Patient patient, Doctor doctor, DateTime date)
    {
        Patient = patient;
        Doctor = doctor;
        Date = date;
    }
}