using HospitalLib.Models;
using Repositories.Interfaces;

namespace HospitalApi.Services
{
    public class DoctorService
    {
        private readonly IDoctorRepository _doctorRepo;

        public DoctorService(IDoctorRepository doctorRepo)
        {
            _doctorRepo = doctorRepo;
        }

        public IEnumerable<Doctor> GetAllDoctors() => _doctorRepo.GetAll();

        public Doctor GetDoctorById(Guid id) => _doctorRepo.GetById(id);

        public Doctor AddDoctor(Doctor doctor)
        {
            if (string.IsNullOrWhiteSpace(doctor.Name))
                throw new ArgumentException("Doctor name is required.");

            return _doctorRepo.Add(doctor);
        }

        public Doctor UpdateDoctor(Guid id, Doctor updatedDoctor)
        {
            var existing = _doctorRepo.GetById(id);
            if (existing == null) throw new Exception("Doctor not found");

            updatedDoctor.Id = id;
            return _doctorRepo.Update(updatedDoctor);
        }

        public void DeleteDoctor(Guid id) => _doctorRepo.Delete(id);
    }
}
