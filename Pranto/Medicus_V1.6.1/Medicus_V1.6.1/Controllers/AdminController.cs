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
            return View();
        }

        public ActionResult POS()
        {
            return View();
        }

        public ActionResult MedicineList()
        {
            PharmacyMedicineViewData data = new PharmacyMedicineViewData();
            data.medicineList = db.Database.SqlQuery<MultipleModelInOneClass>("select * from medicines inner join pharmacyreceiveds on medicines.medicineid = pharmacyreceiveds.medicineid order by pharmacyreceiveds.quantity").ToList();
            return View(data);
        }
        public ActionResult AlertStockList()
        {
            AlertStockListViewData data = new AlertStockListViewData();
            data.stockList = db.Database.SqlQuery<MultipleModelInOneClass>("select * from medicines inner join pharmacyreceiveds on medicines.medicineid = pharmacyreceiveds.medicineid order by pharmacyreceiveds.quantity").ToList();
            return View(data);
        }
        public ActionResult AllSales()
        {
            return View();
        }
        public ActionResult OrderMedicine()
        {
            return View();
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
    }
}