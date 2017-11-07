using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCrud.Core.Domain
{
    public class Employee
    {
        public Employee()
        {
            ServicesEquipments = new HashSet<ServiceEquipment>();
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public string HiringManagerEmail { get; set; }
        public string FullName { get; set; }
        public int JobPositionId { get; set; }
        public JobPosition JobPosition { get; set; }
        public string OtherJobPosition { get; set; }
        public string PersonalEmail { get; set; }
        public string MobileNumber { get; set; }
        public DateTime StartDate { get; set; }
        public virtual ICollection<ServiceEquipment> ServicesEquipments { get; set; }

        public string OtherServiceEquipment { get; set; }

        public string AdditionalServices { get; set; }

        public int CompanyId { get; set; }

        public Company Company { get; set; }

        public string CompanyOther { get; set; }


    }
}