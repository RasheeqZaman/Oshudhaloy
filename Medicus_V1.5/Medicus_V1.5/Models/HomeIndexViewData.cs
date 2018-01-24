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
<<<<<<< HEAD
=======
        public int totalExpenses { get; set; }
        public int totalRevenue { get; set; }
>>>>>>> 048521e896725079f375d4c2ff13e56bbc940e30
        public List<Pharmacy> pharmacyList { get; set; }

    }
}