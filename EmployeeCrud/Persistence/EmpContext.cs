using EmployeeCrud.Core.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeCrud.Persistence
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("name=EmpContext")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Employee> Employees {get; set;}
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<JobPosition> JobPositions { get; set; }
        public virtual DbSet<ServiceEquipment> ServiceEquipments { get; set; }
        public virtual DbSet<Building> Buildings { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new EmpConfiguration());
        }
    }
}