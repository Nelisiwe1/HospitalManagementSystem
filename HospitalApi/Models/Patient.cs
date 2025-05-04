namespace HospitalManagementSystem.Models
{
    public class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }

        // Constructor
        public Patient(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
