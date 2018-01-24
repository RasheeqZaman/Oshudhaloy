using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class PharmacyContext : DbContext
    {
        public DbSet<Customers> CustomerTable { get; set; }
        public DbSet<Employee> EmployeeTable { get; set; }
        public DbSet<Pharmacy> PharmacyTable { get; set; }
    }
}