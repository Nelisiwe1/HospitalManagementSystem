using HospitalManagementSystem.Models;  // Import the Models namespace

namespace HospitalTests.Tests
{
    public class InMemoryAppointmentRepositoryTests
    {
        [Fact]
        public void CreateAppointment_WithValidData_ReturnsAppointment()
        {
            var patient = new Patient("John Doe", 25);
            var doctor = new Doctor("Dr. Smith", "Cardiology");
            var appointment = new Appointment(patient, doctor, DateTime.Now, "Routine Checkup");

            Assert.NotNull(appointment);
            Assert.Equal("John Doe", appointment.Patient.Name);
            Assert.Equal("Dr. Smith", appointment.Doctor.Name);
            Assert.Equal("Routine Checkup", appointment.Description);
        }
    }
}
