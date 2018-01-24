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

            var medicineList = new List<Medicine>
            {
                new Medicine {Name = "Acetaminophen", GenericName = "Ace", SupplierPrice = 20, SellPrice = 25, Catagory = "Tablet", Details = "Usual Adult Dose for Fever:1000 mg" },
                new Medicine {Name = "Clindamycin", GenericName = "Cleocin HCl", SupplierPrice = 30, SellPrice = 35, Catagory = "Capsule", Details = "Usual Adult Dose for Acidity:100 mg" },
                new Medicine {Name = "Lisinopril", GenericName = "Prinivil", SupplierPrice = 50, SellPrice = 60, Catagory = "Syrup", Details = "Usual Child Dose for Hypertension:20 mg" },
                new Medicine {Name = "Tramadol", GenericName = "ConZip", SupplierPrice = 25, SellPrice = 40, Catagory = "Syrup", Details = "Usual Adult Dose for Pain:50 mg" },
                new Medicine {Name = "Oxycodone", GenericName = "Oxaydo", SupplierPrice = 10, SellPrice = 15, Catagory = "Tablet", Details = "Usual Adult Dose for Pain:15 mg" },
            };
            foreach (var temp in medicineList)
            {
                context.MedicineTable.Add(temp);
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

            var adminList = new List<Admin>
            {
                new Admin {UserName = "Nahid Pranto", Email = "np@gmail.com", Password = "np", PharmacyId = 1, PhoneNumber = "0443", Address = "Dhaka" },
                new Admin {UserName = "Rumu Biswas", Email = "rb@gmail.com", Password = "rb", PharmacyId = 2, PhoneNumber = "4321", Address = "Chadpur" },
                new Admin {UserName = "Richie Rozario", Email = "rr@gmail.com", Password = "rr", PharmacyId = 3, PhoneNumber = "6243", Address = "Tangail" },
                new Admin {UserName = "Tonmoy Sinha", Email = "ts@gmail.com", Password = "ts", PharmacyId = 4, PhoneNumber = "5313", Address = "Comilla" },
                new Admin {UserName = "Shohan Arko", Email = "sa@gmail.com", Password = "sa", PharmacyId = 5, PhoneNumber = "3148", Address = "Mymensingh" }
            };
            foreach (var temp in adminList)
            {
                context.AdminTable.Add(temp);
            }
            context.SaveChanges();

            var supplierList = new List<Supplier>
            {
                new Supplier {UserName = "Sanjana Khan", Email = "sk@gmail.com", PhoneNumber = "1443"},
                new Supplier {UserName = "Ahnaf Tahseen", Email = "at@gmail.com", PhoneNumber = "0543"},
                new Supplier {UserName = "Radwan Rahman", Email = "rr2@gmail.com", PhoneNumber = "0787"},
                new Supplier {UserName = "Irin Suha", Email = "is@gmail.com", PhoneNumber = "0483"},
                new Supplier {UserName = "Salvi Faravi", Email = "sf@gmail.com", PhoneNumber = "9443"}
            };
            foreach (var temp in supplierList)
            {
                context.SupplierTable.Add(temp);
            }
            context.SaveChanges();

            var pharmacyOrderList = new List<Pharmacy_Order>
            {
                new Pharmacy_Order {AdminId = 1, SupplierId = 3, MedicineId = 2, Quantity = 10, OrderDate = DateTime.Parse("2017-02-20")},
                new Pharmacy_Order {AdminId = 2, SupplierId = 1, MedicineId = 3, Quantity = 50, OrderDate = DateTime.Parse("2017-06-20")},
                new Pharmacy_Order {AdminId = 3, SupplierId = 1, MedicineId = 2, Quantity = 10, OrderDate = DateTime.Parse("2017-02-20")},
                new Pharmacy_Order {AdminId = 2, SupplierId = 2, MedicineId = 5, Quantity = 50, OrderDate = DateTime.Parse("2017-07-20")},
                new Pharmacy_Order {AdminId = 3, SupplierId = 4, MedicineId = 5, Quantity = 70, OrderDate = DateTime.Parse("2017-02-20")},
                new Pharmacy_Order {AdminId = 2, SupplierId = 3, MedicineId = 5, Quantity = 15, OrderDate = DateTime.Parse("2017-06-28")},
                new Pharmacy_Order {AdminId = 4, SupplierId = 1, MedicineId = 4, Quantity = 25, OrderDate = DateTime.Parse("2017-02-20")},
                new Pharmacy_Order {AdminId = 4, SupplierId = 3, MedicineId = 2, Quantity = 25, OrderDate = DateTime.Parse("2017-02-22")},
                new Pharmacy_Order {AdminId = 5, SupplierId = 3, MedicineId = 2, Quantity = 35, OrderDate = DateTime.Parse("2017-02-25")},
                new Pharmacy_Order {AdminId = 5, SupplierId = 5, MedicineId = 1, Quantity = 20, OrderDate = DateTime.Parse("2017-06-21")},
                new Pharmacy_Order {AdminId = 1, SupplierId = 3, MedicineId = 2, Quantity = 20, OrderDate = DateTime.Parse("2017-03-10")},
            };
            foreach (var temp in pharmacyOrderList)
            {
                context.PharmacyOrderTable.Add(temp);
            }
            context.SaveChanges();

<<<<<<< HEAD
            var pharmacyReceiveList = new List<Pharmacy_Received>
            {
                new Pharmacy_Received {Pharmacy_OrderId = 1, ReceiveDate = DateTime.Parse("2018-06-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 2, ReceiveDate = DateTime.Parse("2018-06-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 3, ReceiveDate = DateTime.Parse("2018-06-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 4, ReceiveDate = DateTime.Parse("2018-06-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 5, ReceiveDate = DateTime.Parse("2018-06-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 6, ReceiveDate = DateTime.Parse("2018-06-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 9, ReceiveDate = DateTime.Parse("2018-06-25")}
=======
            var customerOrderList = new List<CustomerOrder>
            {
                new CustomerOrder {CustomerId = 1, EmployeeId = 3, MedicineId = 2, Quantity = 10, OrderDate = DateTime.Parse("2017-02-20")},
                new CustomerOrder {CustomerId = 2, EmployeeId = 1, MedicineId = 3, Quantity = 50, OrderDate = DateTime.Parse("2017-06-20")},
                new CustomerOrder {CustomerId = 3, EmployeeId = 1, MedicineId = 2, Quantity = 10, OrderDate = DateTime.Parse("2017-02-20")},
                new CustomerOrder {CustomerId = 2, EmployeeId = 2, MedicineId = 5, Quantity = 50, OrderDate = DateTime.Parse("2017-07-20")},
                new CustomerOrder {CustomerId = 3, EmployeeId = 4, MedicineId = 5, Quantity = 70, OrderDate = DateTime.Parse("2017-02-20")},
                new CustomerOrder {CustomerId = 2, EmployeeId = 3, MedicineId = 5, Quantity = 15, OrderDate = DateTime.Parse("2017-06-28")},
                new CustomerOrder {CustomerId = 4, EmployeeId = 1, MedicineId = 4, Quantity = 25, OrderDate = DateTime.Parse("2017-02-20")},
                new CustomerOrder {CustomerId = 4, EmployeeId = 3, MedicineId = 2, Quantity = 25, OrderDate = DateTime.Parse("2017-02-22")},
                new CustomerOrder {CustomerId = 5, EmployeeId = 3, MedicineId = 2, Quantity = 35, OrderDate = DateTime.Parse("2017-02-25")},
                new CustomerOrder {CustomerId = 5, EmployeeId = 5, MedicineId = 1, Quantity = 20, OrderDate = DateTime.Parse("2017-06-21")},
                new CustomerOrder {CustomerId = 1, EmployeeId = 3, MedicineId = 2, Quantity = 20, OrderDate = DateTime.Parse("2017-03-10")},
            };
            foreach (var temp in customerOrderList)
            {
                context.CustomerOrderTable.Add(temp);
            }
            context.SaveChanges();

            var pharmacyReceiveList = new List<Pharmacy_Received>
            {
                new Pharmacy_Received {Pharmacy_OrderId = 1, ReceiveDate = DateTime.Parse("2018-06-25"), ExpireDate = DateTime.Parse("2018-09-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 2, ReceiveDate = DateTime.Parse("2018-06-25"), ExpireDate = DateTime.Parse("2018-10-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 3, ReceiveDate = DateTime.Parse("2018-06-25"), ExpireDate = DateTime.Parse("2018-12-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 4, ReceiveDate = DateTime.Parse("2018-06-25"), ExpireDate = DateTime.Parse("2018-11-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 5, ReceiveDate = DateTime.Parse("2018-06-25"), ExpireDate = DateTime.Parse("2018-07-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 6, ReceiveDate = DateTime.Parse("2018-04-25"), ExpireDate = DateTime.Parse("2018-09-25")},
                new Pharmacy_Received {Pharmacy_OrderId = 9, ReceiveDate = DateTime.Parse("2018-05-25"), ExpireDate = DateTime.Parse("2018-09-25")}
>>>>>>> 048521e896725079f375d4c2ff13e56bbc940e30
            };
            foreach (var temp in pharmacyReceiveList)
            {
                context.PharmacyReceiveTable.Add(temp);
            }
            context.SaveChanges();
<<<<<<< HEAD
=======

            var pharmacySoldList = new List<PharmacySold>
            {
                new PharmacySold {Customer_OrderId = 1, ReceiveDate = DateTime.Parse("2018-06-25")},
                new PharmacySold {Customer_OrderId = 2, ReceiveDate = DateTime.Parse("2018-06-25")},
                new PharmacySold {Customer_OrderId = 3, ReceiveDate = DateTime.Parse("2018-06-25")},
                new PharmacySold {Customer_OrderId = 4, ReceiveDate = DateTime.Parse("2018-06-25")},
                new PharmacySold {Customer_OrderId = 5, ReceiveDate = DateTime.Parse("2018-06-25")},
                new PharmacySold {Customer_OrderId = 6, ReceiveDate = DateTime.Parse("2018-04-25")},
                new PharmacySold {Customer_OrderId = 9, ReceiveDate = DateTime.Parse("2018-05-25")}
            };
            foreach (var temp in pharmacySoldList)
            {
                context.PharmacySoldTable.Add(temp);
            }
            context.SaveChanges();

>>>>>>> 048521e896725079f375d4c2ff13e56bbc940e30
        }
    }
}