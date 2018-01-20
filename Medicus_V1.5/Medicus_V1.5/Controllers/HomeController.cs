using Medicus_V1._5.Models;
using System;
using System.Collections.Generic;
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
            data.customersList = db.CustomerTable.ToList();
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
    }
}