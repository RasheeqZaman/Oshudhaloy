using Medicus_V1._6._1.Models;
using Medicus_V1._6._1.ViewData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicus_V1._6._1.Controllers
{
    public class AdminController : Controller
    {
        PharmacyContext db = new PharmacyContext();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            var data = new AdminDashBoardViewData();
            data.todaysTotalCustomer = db.Database.SqlQuery<int>("SELECT COUNT(CustomerId) FROM CustomerOrders inner join Admins on Admins.pharmacyId = CustomerOrders.pharmacyId WHERE Admins.adminId = "+ Session["ID"] + " and OrderDate = '"+DateTime.Today+"'").FirstOrDefault();
            //data.todaysTotalSale = db.Database.SqlQuery<int>("SELECT SUM(Medicines.SellPrice*CustomerOrders.Quantity) FROM CustomerOrders INNER JOIN Medicines ON CustomerOrders.MedicineId = Medicines.MedicineId INNER JOIN CustomerCarts ON CustomerOrders.CustomerOrderId = CustomerCarts.CustomerOrderId INNER JOIN PharmacySolds ON PharmacySolds.CustomerCartId = CustomerCarts.CCartId Inner join Admins on Admins.PharmacyId = CustomerOrders.PharmacyId WHERE Admins.adminId = "+Session["ID"]+" and SoldDate = '"+DateTime.Today +"'").FirstOrDefault(); ;
            data.todaysTotalSale = 0;
            //data.todaysTotalPurchase = db.Database.SqlQuery<int>("SELECT sum(Medicines.supplierPrice*PharmacyReceiveds.Quantity) FROM PharmacyReceiveds inner join Medicines on Medicines.MedicineId = PharmacyReceiveds.MedicineId inner join Admins on Admins.pharmacyId = CustomerOrders.pharmacyId WHERE Admins.adminId = " + Session["ID"] + " and PharmacyReceiveds.ReceivedDate = '" + DateTime.Today + "'").FirstOrDefault();
            data.todaysTotalPurchase = 0;
            //data.totalMedicine = db.Database.SqlQuery<int>("SELECT SUM(Quantity) FROM PharmacyReceiveds Inner join Admins on Admins.PharmacyId = PharmacyReceiveds.PharmacyId WHERE Admins.adminid = "+Session["ID"]+" and ReceivedDate = '"+DateTime.Today+"'").FirstOrDefault();
            string check =  db.Database.SqlQuery<int?>("SELECT SUM(Quantity) FROM PharmacyReceiveds where PharmacyId = 15").FirstOrDefault().ToString();
            if (check == null)
            {
                data.totalMedicine = 0;
            }else
            {
                data.totalMedicine = Int32.Parse(check);
            }
            //data.totalMedicine = 0;
            return View(data);
        }

        public ActionResult POS()
        {
            return View();
        }

        public ActionResult MedicineList()
        {
            PharmacyMedicineViewData data = new PharmacyMedicineViewData();
            data.medicineList = db.Database.SqlQuery<MultipleModelInOneClass>("select * from medicines inner join pharmacyreceiveds on medicines.medicineid = pharmacyreceiveds.medicineid").ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult MedicineList(string keyword)
        {
            PharmacyMedicineViewData data = new PharmacyMedicineViewData();
            data.medicineList = db.Database.SqlQuery<MultipleModelInOneClass>("select * from medicines inner join pharmacyreceiveds on medicines.medicineid = pharmacyreceiveds.medicineid where name = '" + keyword + "' ").ToList();
            return View(data);
        }

        public ActionResult AlertStockList()
        {
            AlertStockListViewData data = new AlertStockListViewData();
            data.stockList = db.Database.SqlQuery<MultipleModelInOneClass>("select * from medicines inner join pharmacyreceiveds on medicines.medicineid = pharmacyreceiveds.medicineid  order by pharmacyreceiveds.quantity").ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult AlertStockList(string keyword)
        {
            AlertStockListViewData data = new AlertStockListViewData();
            data.stockList = db.Database.SqlQuery<MultipleModelInOneClass>("select * from medicines inner join pharmacyreceiveds on medicines.medicineid = pharmacyreceiveds.medicineid where name = '" + keyword + "'order by pharmacyreceiveds.quantity").ToList();
            return View(data);
        }
        public ActionResult AllSales()
        {
            return View();
        }
        
        public ActionResult OrderMedicine()
        {
            var data = new PharmacyOrderMedicineViewData();
            data.medicineList = db.MedicineTable.ToList();
            data.supplierList = db.SupplierTable.ToList();
            return View(data);
        }

        [HttpPost]
        public ActionResult OrderMedicine(PharmacyOrderMedicineViewData viewModel)
        {

            if (ModelState.IsValid)
            {
                PharmacyReceived p = new PharmacyReceived
                {
                    PharmacyId = Int32.Parse(Session["ID"].ToString()),
                    SupplierId = viewModel.supplierId,
                    MedicineId = viewModel.medicineId,
                    Quantity = viewModel.quantity,
                    ReceivedDate = DateTime.Today,
                    ExpireDate = viewModel.expiredDate
                };
                db.PharmacyReceivedTable.Add(p);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }
        public ActionResult AllOrder()
        {
            AdminAllorderViewData data = new AdminAllorderViewData();
            data.orderList = db.Database.SqlQuery<MultipleModelInOneClass>("select * from pharmacyreceiveds").ToList();
            return View(data);
        }
        public ActionResult TodayReport()
        {
            return View();
        }

        public ActionResult SalesReport()
        {
            return View();
        }
        public ActionResult PurchaseReport()
        {
            return View();
        }
        public ActionResult Staff()
        {
            EmployeeViewData data = new EmployeeViewData();
            data.employeeList = db.EmployeeTable.SqlQuery("select * from employees").ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult Staff(string keyword)
        {
            EmployeeViewData data = new EmployeeViewData();
            data.employeeList= db.EmployeeTable.SqlQuery("select * from employees where username = '" + keyword + "'").ToList();
            return View(data);
        }
        

        public ActionResult InvoiceInfo()
        {
            return View();
        }
        public ActionResult CustomerInfo()
        {
            CustomerInfoViewData data = new CustomerInfoViewData();
            data.customerList = db.CustomerTable.SqlQuery("Select * from customers").ToList();
            return View(data);
        }
        [HttpPost]
        public ActionResult CustomerInfo(string keyword)
        {
            CustomerInfoViewData data = new CustomerInfoViewData();
            data.customerList = db.CustomerTable.SqlQuery("select * from customers where username = '" + keyword + "'").ToList();
            return View(data);
        }

        public ActionResult AddMedicine()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddMedicine(AdminAddMedicineViewData viewModel)
        {

            if (ModelState.IsValid)
            {
                Medicine m = new Medicine
                {
                    SellPrice = viewModel.sellPrice,
                    SupplierPrice = viewModel.supplierPrice,
                    Name = viewModel.medicineName,
                    Catagory = viewModel.category,
                    Details = viewModel.details,
                    GenericName = viewModel.genericName
                };
                db.MedicineTable.Add(m);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }
        public ActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddStaff(AdminAddStaffViewData viewModel)
        {

            if (ModelState.IsValid)
            {
                Employee e = new Employee
                {
                    UserName = viewModel.userName,
                    Email = viewModel.email,
                    PhoneNumber = viewModel.phoneNumber,
                    Address=viewModel.address,
                    Password=viewModel.password

                };
                db.EmployeeTable.Add(e);
                db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }

        

    }
}