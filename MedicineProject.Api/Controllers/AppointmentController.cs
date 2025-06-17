using MedicineProject.Core.Services;
using MedicineProject.Core.Services.IServices;
using MedicineProject.Data.Entities.Appointments;
using Microsoft.AspNetCore.Mvc;

namespace MedicineProject.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AppointmentController : ControllerBase
    {
        private readonly IAppointmentService _service;
        public AppointmentController(IAppointmentService service) 
        {
            _service = service;
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync(string id)
        {
            var appointment = await _service.GetByIdAsync(id);
            return Ok(appointment);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var appointments = await _service.GetAllAsync();
            return Ok(appointments);
        }
        [HttpPost]
        public async Task<IActionResult> CreateAsync(Appointment appointment)
        {
            appointment = await _service.AddAsync(appointment);
            return Ok(appointment);
        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAsync(Appointment appointment)
        {
            appointment = await _service.UpdateAsync(appointment);
            return Ok(appointment);
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAsync(string id)
        {
            var appointment = await _service.DeleteAsync(id);
            return Ok(appointment);
        }
    }
}
