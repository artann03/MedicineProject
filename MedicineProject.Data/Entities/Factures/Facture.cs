using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.FactureDiagnosises;
using MedicineProject.Data.Entities.FactureExaminations;
using MedicineProject.Data.Entities.FactureServices;
using MedicineProject.Data.Entities.FactureTherapies;
using MedicineProject.Data.Entities.Patients;
using MedicineProject.Data.Entities.Users;

namespace MedicineProject.Data.Entities.Factures
{
    public class Facture : BaseEntity
    {
        public string PatientId { get; set; }
        public Patient Patient { get; set; }

        public string DoctorId { get; set; }
        public User Doctor { get; set; }

        public DateTime VisitDate { get; set; }
        public string Complaint { get; set; }
        public string Recommendation { get; set; }
        public DateTime? NextVisitDate { get; set; }

        public ICollection<FactureExamination> Examinations { get; set; }
        public ICollection<FactureDiagnosis> Diagnoses { get; set; }
        public ICollection<FactureTherapy> Therapies { get; set; }
        public ICollection<FactureService> Services { get; set; }
    }
}
