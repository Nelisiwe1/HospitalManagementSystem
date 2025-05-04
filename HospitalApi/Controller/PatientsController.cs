using HospitalLib.Models;
using Microsoft.AspNetCore.Mvc;
using HospitalApi.Services;

namespace HospitalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PatientsController : ControllerBase
    {
        private readonly PatientService _service;

        public PatientsController(PatientService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAllPatients());

        [HttpPost]
        public IActionResult Create(Patient patient) => Ok(_service.AddPatient(patient));
    }
}
