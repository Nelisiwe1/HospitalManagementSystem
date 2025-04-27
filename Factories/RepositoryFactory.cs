using HospitalManagementSystem.Repositories.InMemory;

namespace HospitalManagementSystem.Factories
{
    public class RepositoryFactory
    {
        public static object GetRepository(string entityType, string storageType)
        {
            if (storageType == "MEMORY")
            {
                return entityType switch
                {
                    "Patient" => new InMemoryPatientRepository(),
                    "Doctor" => new InMemoryDoctorRepository(),
                    "Appointment" => new InMemoryAppointmentRepository(),
                    "Billing" => new InMemoryBillingRepository(),
                    _ => throw new System.ArgumentException("Invalid entity type")
                };
            }
            else
            {
                throw new System.ArgumentException("Invalid storage type");
            }
        }
    }
}