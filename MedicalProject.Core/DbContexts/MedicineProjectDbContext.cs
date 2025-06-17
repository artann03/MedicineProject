using MedicineProject.Data.Entities.Appointments;
using MedicineProject.Data.Entities.BaseEntities;
using MedicineProject.Data.Entities.FactureDiagnosises;
using MedicineProject.Data.Entities.FactureExaminations;
using MedicineProject.Data.Entities.Factures;
using MedicineProject.Data.Entities.FactureServices;
using MedicineProject.Data.Entities.FactureTherapies;
using MedicineProject.Data.Entities.Patients;
using MedicineProject.Data.Entities.Users;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MedicineProject.Core.DbContexts
{
    public class MedicineProjectDbContext : DbContext
    {
        public MedicineProjectDbContext(DbContextOptions<MedicineProjectDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<FactureExamination> FactureExaminations { get; set; }
        public DbSet<FactureDiagnosis> FactureDiagnoses { get; set; }
        public DbSet<FactureTherapy> FactureTherapies { get; set; }
        public DbSet<FactureService> FactureServices { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(BaseEntity).IsAssignableFrom(entityType.ClrType))
                {
                    var parameter = Expression.Parameter(entityType.ClrType, "e");
                    var isDeletedProperty = Expression.Property(parameter, nameof(BaseEntity.IsDeleted));
                    var filter = Expression.Lambda(Expression.Equal(isDeletedProperty, Expression.Constant(false)), parameter);
                    modelBuilder.Entity(entityType.ClrType).HasQueryFilter(filter);
                }
            }
        }
    }
}
