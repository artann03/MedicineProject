using MedicineProject.Core.Repository.IRepository;
using MedicineProject.Core.Services.IServices;
using MedicineProject.Data.Entities.Appointments;

namespace MedicineProject.Core.Services
{
    public class AppointmentService : BaseService<Appointment>, IAppointmentService
    {
        public AppointmentService(IAppointmentRepository appointmentRepository) : base(appointmentRepository) { }
    }
}
