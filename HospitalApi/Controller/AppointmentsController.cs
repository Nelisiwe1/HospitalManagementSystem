using HospitalLib.Models;
using Microsoft.AspNetCore.Mvc;
using HospitalApi.Services;

namespace HospitalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentsController : ControllerBase
    {
        private readonly AppointmentService _service;

        public AppointmentsController(AppointmentService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAllAppointments());

        [HttpPost]
        public IActionResult Create(Appointment appointment) => Ok(_service.AddAppointment(appointment));
    }
}
