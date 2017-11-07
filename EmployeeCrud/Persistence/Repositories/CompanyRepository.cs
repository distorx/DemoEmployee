using EmployeeCrud.Core.Domain;
using EmployeeCrud.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCrud.Persistence.Repositories
{
    public class CompanyRepository: Repository<Company>, ICompanyRepository
    {
        public CompanyRepository(EmpContext context) :base(context)
        {

        }
        public EmpContext EmpContext
        {
            get { return Context as EmpContext; }
        }
    }
}