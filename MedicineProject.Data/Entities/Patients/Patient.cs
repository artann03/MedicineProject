using MedicineProject.Data.Entities.Appointments;
using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.Factures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Data.Entities.Patients
{
    public class Patient : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string InsuranceProvider { get; set; }
        public string InsuranceNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }

        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Facture> Factures { get; set; }
    }
}
