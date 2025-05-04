namespace HospitalManagementSystem.Models
{
    public class Appointment
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public Patient Patient { get; set; }
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }

        // Constructor
        public Appointment(Patient patient, Doctor doctor, DateTime date, string description = "")
        {
            Id = Guid.NewGuid().ToString();  // Assign a unique ID
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Description = description;
        }
    }
}
