using EmployeeCrud.Core;
using EmployeeCrud.Core.Repositories;
using EmployeeCrud.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCrud.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EmpContext _context;
        public UnitOfWork(EmpContext context)
        {
            _context = context;
            Employees = new EmployeeRepository(_context);
            Companies = new CompanyRepository(_context);
            ServiceEquipments = new ServiceEquipmentRepository(_context);
            JobPositions = new JobPositionRepository(context);
        }

        public IEmployeeRepository Employees { get; private set; }
        public ICompanyRepository Companies { get; private set; }
        public IServiceEquipmentRepository ServiceEquipments { get; private set; }
        public IJobPositionRepository JobPositions { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}