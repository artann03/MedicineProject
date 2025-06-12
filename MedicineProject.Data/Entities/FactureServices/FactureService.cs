using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.Factures;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicineProject.Data.Entities.FactureServices
{
    public class FactureService : BaseEntity
    {
        public string FactureId { get; set; }
        public Facture Facture { get; set; }

        public string ServiceName { get; set; }
        public decimal Cost { get; set; }
    }
}
