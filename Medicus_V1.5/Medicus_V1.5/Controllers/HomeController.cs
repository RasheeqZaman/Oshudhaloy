using Medicus_V1._5.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicus_V1._5.Controllers
{
    public class HomeController : Controller
    {
        private PharmacyContext db = new PharmacyContext();
        public ActionResult Index()
        {
            var data = new HomeIndexViewData();
            int checkAdminDashBoard = 2;
            data.customersList = db.CustomerTable.ToList();
            data.totalMedicine = db.Database.SqlQuery<int>("select sum(quantity) from pharmacy_order inner join pharmacy_received on pharmacy_order.pharmacy_orderid = pharmacy_received.pharmacy_orderid where pharmacy_order.adminid = "+checkAdminDashBoard.ToString()).First();
            data.totalExpenses = db.Database.SqlQuery<int>("select sum(pharmacy_order.quantity*medicines.supplierprice) from pharmacy_order inner join pharmacy_received on pharmacy_order.pharmacy_orderid = pharmacy_received.pharmacy_orderid inner join medicines on medicines.medicineid = pharmacy_order.medicineid where pharmacy_order.adminid = " + checkAdminDashBoard.ToString()).First();
            data.employeeList = db.EmployeeTable.SqlQuery("select * from Employees where pharmacyid = 2").ToList();
            data.pharmacyList = db.PharmacyTable.ToList();
            return View(data);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult POS()
        {
            return View();
        }

        public ActionResult AllSales()
        {
            return View();
        }
        public ActionResult Staff()
        {
            return View();
        }
        public ActionResult Supplier()
        {
            return View();
        }
        public ActionResult MedicineList()
        {
            return View();
        }
        public ActionResult AlertStockList()
        {
            return View();
        }
        public ActionResult OrderMedicine()
        {
            return View();
        }

        [HttpPost]
        public ActionResult OrderMedicine(Medicine medicine)
        {

            if (ModelState.IsValid)
            {
                db.MedicineTable.Add(new Medicine
                {
                    Name = medicine.Name,
                    GenericName = medicine.GenericName,
                    Details = medicine.Details,
                    Catagory = medicine.Catagory,
                    SellPrice = medicine.SellPrice,
                    SupplierPrice = medicine.SupplierPrice
                });
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(medicine);
        }

        public ActionResult AllOrder()
        {
            return View();
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
    }
}