using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.Patients;
using MedicineProject.Data.Entities.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Data.Entities.Appointments
{
    public class Appointment : BaseEntity
    {
        public Patient Patient { get; set; }

        public string DoctorId { get; set; }
        public User Doctor { get; set; }

        public DateTime AppointmentTime { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }
    }
}
