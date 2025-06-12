using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Data.Entities.FactureTherapies
{
    public class FactureTherapy : BaseEntity
    {
        public string FactureId { get; set; }
        public Facture Facture { get; set; }

        public string MedicationName { get; set; }
        public string Dosage { get; set; }
        public string Instructions { get; set; }
    }
}
