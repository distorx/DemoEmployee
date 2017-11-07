using EmployeeCrud.Core.Domain;
using EmployeeCrud.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace EmployeeCrud.Controllers
{
    public class JobPositionController : ApiController
    {
        private UnitOfWork unitOfWork = new UnitOfWork(new EmpContext());

        public IEnumerable<JobPosition> GetJobPositions()
        {
            return unitOfWork.JobPositions.GetAll();
        }

        [ResponseType(typeof(JobPosition))]
        public IHttpActionResult GetJobPosition(int id)
        {
            JobPosition jobPosition = unitOfWork.JobPositions.Get(id);
            if (jobPosition == null)
            {
                return NotFound();
            }

            return Ok(jobPosition);
        }
    }
}
