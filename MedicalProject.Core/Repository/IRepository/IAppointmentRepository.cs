using MedicineProject.Data.Entities.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Core.Repository.IRepository
{
    public interface IAppointmentRepository : IBaseRepository<Appointment>
    {
    }
}
