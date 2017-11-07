namespace EmployeeCrud.Migrations
{
    using EmployeeCrud.Core.Domain;
    using EmployeeCrud.Persistence;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeCrud.Persistence.EmpContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeCrud.Persistence.EmpContext context)
        {

            //SeedJobPosition(context);
            //SeedCompanies(context);
            //SeedServiceEquipments(context);
            //SeedBuilding(context);

        }

        private void SeedBuilding(EmpContext context)
        {
            List<Building> list = new List<Building> {
                new Building {Name = "Headquarters. Call Center - building 200"},
                new Building {Name = "Headquarters, Main Building - building 300"},
                new Building {Name = "Other:"}
            };

            foreach (var building in list)
            {
                context.Buildings.Add(building);
            }
        }

        private void SeedCompanies(EmpContext context)
        {
            List<Company> list = new List<Company> {
                new Company {Name = "Addiction Recovery Now"},
                new Company {Name = "Comfort Recovery"},
                new Company {Name = "Discovery Point Retreat"},
                new Company {Name = "Hope Canyon Recovery"},
                new Company {Name = "Niznik Behavioral Health"},
                new Company {Name = "Niznik Behavioral Health Resources"},
                new Company {Name = "Niznik Lab Corp"},
                new Company {Name = "Palms Detox"},
                new Company {Name = "Paradise Detox"},
                new Company {Name = "Opus Behavioral Health"},
                new Company {Name = "Safe Landing Recovery"},
                new Company {Name = "U.S. Billing Resources"},
                new Company {Name = "U.S. Health Corp Lab"},
                new Company {Name = "Others:"}
            };

            foreach (var company in list)
            {
                context.Companies.Add(company);
            }
        }

        private void SeedServiceEquipments(EmpContext context)
        {
            List<ServiceEquipment> list = new List<ServiceEquipment>
            {
                new ServiceEquipment {Name = "Company email"},
                new ServiceEquipment {Name = "Opus login"},
                new ServiceEquipment {Name = "Desk"},
                new ServiceEquipment {Name = "Computer"},
                new ServiceEquipment {Name = "Landline extension"},
                new ServiceEquipment {Name = "Company mobile phone"},
                new ServiceEquipment {Name = "Company laptop"},
                new ServiceEquipment {Name = "ADP (includes being enrolled in time clock)"},
                new ServiceEquipment {Name = "Other:"},
            };

            foreach (var serviceEquipment in list)
            {
                context.ServiceEquipments.Add(serviceEquipment);
            }
        }

        private void SeedJobPosition(EmpContext context)
        {
            
            List<JobPosition> list = new List<JobPosition> {
                new JobPosition { Name = "Behavioral Health Technician (BHT)" },
                new JobPosition { Name = "Call Center" },
                new JobPosition { Name = "Case Manager" },
                new JobPosition { Name = "Licensed Practical Nurse (LPN or LVN)" },
                new JobPosition { Name = "Massage Therapist" },
                new JobPosition { Name = "Medical Assistant" },
                new JobPosition { Name = "Marketing" },
                new JobPosition { Name = "Medical Doctor" },
                new JobPosition { Name = "Nurse Practitioner" },
                new JobPosition { Name = "Physician" },
                new JobPosition { Name = "Recovery Coach" },
                new JobPosition { Name = "Registered Nurse (RN)" },
                new JobPosition { Name = "Therapist" },
                new JobPosition { Name = "Accounting" },
                new JobPosition { Name = "Administrative, Corporate or Executive" },
                new JobPosition { Name = "Other:" } };

            foreach (var jobPosition in list)
            {
                context.JobPositions.Add(jobPosition);
            }

        }
    }
}
