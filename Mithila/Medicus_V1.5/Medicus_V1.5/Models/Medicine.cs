using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class Medicine
    {
        public int PharmacyId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Employee> EmployeeAll { get; set; }
    }
}