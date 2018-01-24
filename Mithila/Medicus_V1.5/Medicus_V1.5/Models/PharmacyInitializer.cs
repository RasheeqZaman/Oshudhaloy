using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Medicus_V1._5.Models
{
    public class PharmacyInitializer:DropCreateDatabaseIfModelChanges<PharmacyContext>
    {
        protected override void Seed(PharmacyContext context)
        {
            var customerList = new List<Customers>
            {
                new Customers {UserName = "Afrina Zahan Mithila", Email = "az@gmail.com", Password = "az", PhoneNumber = "0123", Address = "Dhaka" },
                new Customers {UserName = "Rakib Hossain Ayon", Email = "rh@gmail.com", Password = "rh", PhoneNumber = "1243", Address = "Barishal" },
                new Customers {UserName = "Sayef Reyadh", Email = "sr@gmail.com", Password = "sr", PhoneNumber = "0143", Address = "Chittagong" },
                new Customers {UserName = "Fahim Ahsan", Email = "fa@gmail.com", Password = "fa", PhoneNumber = "0373", Address = "Rajshahi" },
                new Customers {UserName = "Amir Hamza", Email = "ah@gmail.com", Password = "ah", PhoneNumber = "0343", Address = "Comilla" },
                new Customers {UserName = "Hasib Ahmed", Email = "ha@gmail.com", Password = "ha", PhoneNumber = "0145", Address = "Noakhali" }
            };
            foreach (var temp in customerList)
            {
                context.CustomerTable.Add(temp);
            }
            context.SaveChanges();

            var pharmacyList = new List<Pharmacy>
            {
                new Pharmacy {Name = "Ahsanullah", PhoneNumber = "0123", Address = "Dhaka" },
                new Pharmacy {Name = "Square", PhoneNumber = "1243", Address = "Barishal" },
                new Pharmacy {Name = "Labaid", PhoneNumber = "0143", Address = "Chittagong" },
                new Pharmacy {Name = "Health & Hope", PhoneNumber = "0343", Address = "Comilla" },
                new Pharmacy {Name = "Lazz Pharma", PhoneNumber = "0145", Address = "Noakhali" }
            };
            foreach (var temp in pharmacyList)
            {
                context.PharmacyTable.Add(temp);
            }
            context.SaveChanges();

            var employeeList = new List<Employee>
            {
                new Employee {UserName = "Rasheeq Zaman", Email = "rz@gmail.com", Password = "rz", PharmacyId = 1, PhoneNumber = "0423", Address = "Dhaka" },
                new Employee {UserName = "Arefeen Sultan", Email = "ar@gmail.com", Password = "ar", PharmacyId = 2, PhoneNumber = "7243", Address = "Chadpur" },
                new Employee {UserName = "Labiba Rupty", Email = "lr@gmail.com", Password = "lr", PharmacyId = 1, PhoneNumber = "6143", Address = "Tangail" },
                new Employee {UserName = "Labiba Ibnat", Email = "li@gmail.com", Password = "li", PharmacyId = 3, PhoneNumber = "5343", Address = "Comilla" },
                new Employee {UserName = "Masud Rana", Email = "mr@gmail.com", Password = "mr", PharmacyId = 2, PhoneNumber = "3145", Address = "Mymensingh" }
            };
            foreach (var temp in employeeList)
            {
                context.EmployeeTable.Add(temp);
            }
            context.SaveChanges();
        }
    }
}