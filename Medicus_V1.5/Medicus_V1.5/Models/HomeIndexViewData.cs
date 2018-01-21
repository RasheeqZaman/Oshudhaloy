using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class HomeIndexViewData
    {
        public List<Customers> customersList { get; set; }
        public List<Employee> employeeList { get; set; }
        public int totalMedicine { get; set; }
        public int totalExpenses { get; set; }
        public List<Pharmacy> pharmacyList { get; set; }

    }
}