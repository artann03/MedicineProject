using MedicineProject.Core.DbContexts;
using MedicineProject.Core.Repository.IRepository;
using MedicineProject.Data.Entities.Appointments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Core.Repository
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    { 
        public AppointmentRepository(MedicineProjectDbContext dbContext) : base(dbContext) { }
    }
}
