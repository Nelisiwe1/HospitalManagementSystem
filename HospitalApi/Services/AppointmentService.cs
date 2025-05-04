using HospitalLib.Models;
using Repositories.Interfaces;

namespace HospitalApi.Services
{
    public class AppointmentService
    {
        private readonly IAppointmentRepository _appointmentRepo;

        public AppointmentService(IAppointmentRepository appointmentRepo)
        {
            _appointmentRepo = appointmentRepo;
        }

        public IEnumerable<Appointment> GetAllAppointments() => _appointmentRepo.GetAll();

        public Appointment GetAppointmentById(Guid id) => _appointmentRepo.GetById(id);

        public Appointment BookAppointment(Appointment appointment)
        {
            if (appointment.Date < DateTime.Now)
                throw new ArgumentException("Cannot book an appointment in the past.");

            return _appointmentRepo.Add(appointment);
        }

        public Appointment UpdateAppointment(Guid id, Appointment updatedAppointment)
        {
            var existing = _appointmentRepo.GetById(id);
            if (existing == null) throw new Exception("Appointment not found");

            updatedAppointment.Id = id;
            return _appointmentRepo.Update(updatedAppointment);
        }

        public void CancelAppointment(Guid id) => _appointmentRepo.Delete(id);
    }
}
