using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Data.Entities.FactureDiagnosises
{
    public class FactureDiagnosis : BaseEntity
    {
        public string FactureId { get; set; }
        public Facture Facture { get; set; }

        public string Diagnosis { get; set; }
        public string IcdCode { get; set; }
    }
}
