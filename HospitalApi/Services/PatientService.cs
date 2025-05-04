using HospitalLib.Models;
using Repositories.Interfaces;

namespace HospitalApi.Services
{
    public class PatientService
    {
        private readonly IPatientRepository _patientRepo;

        public PatientService(IPatientRepository patientRepo)
        {
            _patientRepo = patientRepo;
        }

        public IEnumerable<Patient> GetAllPatients() => _patientRepo.GetAll();

        public Patient GetPatientById(Guid id) => _patientRepo.GetById(id);

        public Patient AddPatient(Patient patient)
        {
            if (string.IsNullOrWhiteSpace(patient.Name))
                throw new ArgumentException("Patient name is required.");

            return _patientRepo.Add(patient);
        }

        public Patient UpdatePatient(Guid id, Patient updatedPatient)
        {
            var existing = _patientRepo.GetById(id);
            if (existing == null) throw new Exception("Patient not found");

            updatedPatient.Id = id;
            return _patientRepo.Update(updatedPatient);
        }

        public void DeletePatient(Guid id) => _patientRepo.Delete(id);
    }
}
