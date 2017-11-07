using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeCrud.Core.Domain
{
    public class ServiceEquipment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool Selected { get; set; }
    }
}