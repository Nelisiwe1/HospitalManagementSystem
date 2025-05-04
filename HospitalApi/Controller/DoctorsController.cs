using HospitalLib.Models;
using Microsoft.AspNetCore.Mvc;
using HospitalApi.Services;

namespace HospitalApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorsController : ControllerBase
    {
        private readonly DoctorService _service;

        public DoctorsController(DoctorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetAll() => Ok(_service.GetAllDoctors());

        [HttpPost]
        public IActionResult Create(Doctor doctor) => Ok(_service.AddDoctor(doctor));
    }
}
