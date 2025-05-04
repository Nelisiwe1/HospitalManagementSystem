namespace HospitalManagementSystem.Models
{
    public class Doctor
    {
        public string Name { get; set; }
        public string Specialty { get; set; }

        // Constructor
        public Doctor(string name, string specialty)
        {
            Name = name;
            Specialty = specialty;
        }
    }
}
