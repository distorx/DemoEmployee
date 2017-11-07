using EmployeeCrud.Core.Domain;
using EmployeeCrud.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmployeeCrud.Controllers
{
    public class CompanyController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new EmpContext());

        public IEnumerable<Company> GetCompanies()
        {
            return unitOfWork.Companies.GetAll();
        }

    }
}
