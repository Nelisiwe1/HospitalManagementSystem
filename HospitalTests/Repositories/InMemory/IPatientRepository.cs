using HospitalManagementSystem.Entities;

namespace HospitalManagementSystem.Repositories.InMemory
{
    public interface IPatientRepository : IRepository<Patient, string> {}
}