using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Data.Entities.FactureExaminations
{
    public class FactureExamination : BaseEntity
    {
        public string FactureId { get; set; }
        public Facture Facture { get; set; }

        public string Name { get; set; }
        public string Result { get; set; }
    }
}
