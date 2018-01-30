using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Medicus_V1._6._1.Models
{
    public class PharmacyContext : DbContext
    {

        public DbSet<Customers> CustomerTable { get; set; }
        public DbSet<Employee> EmployeeTable { get; set; }
        public DbSet<Pharmacy> PharmacyTable { get; set; }
        public DbSet<Admin> AdminTable { get; set; }
        public DbSet<Medicine> MedicineTable { get; set; }
        public DbSet<Supplier> SupplierTable { get; set; }
        public DbSet<PharmacyReceived> PharmacyReceivedTable { get; set; }
        public DbSet<CustomerOrder> CustomerOrderTable { get; set; }
        public DbSet<CustomerCart> CustomerCartTable { get; set; }
        public DbSet<PharmacySold> PharmacySoldTable { get; set; }
        
    }
}