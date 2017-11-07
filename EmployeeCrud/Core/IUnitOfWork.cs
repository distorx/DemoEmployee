using EmployeeCrud.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeCrud.Core
{
    public interface IUnitOfWork: IDisposable
    {
        IEmployeeRepository Employees { get;  }
        ICompanyRepository Companies { get;  }
        IJobPositionRepository JobPositions { get; }
        IServiceEquipmentRepository ServiceEquipments { get; }
        int Complete();
    }
}
