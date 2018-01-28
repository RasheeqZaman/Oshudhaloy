using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicus_V1._6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult MedicineList()
        {
            return View();
        }
        public ActionResult PharmacyOrderMedicine()
        {
            return View();
        }
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult CustomerDash()
        {
            return View();
        }
        public ActionResult SideNavBar()
        {
            return View();
        }
        public ActionResult AdminDash()
        {
            return View();
        }
        public ActionResult POS()
        {
            return View();
        }
        public ActionResult SupplierList()
        {
            return View();
        }
        public ActionResult CustomerList()
        {
            return View();
        }
        public ActionResult AddSupplier()
        {
            return View();
        }
        public ActionResult AddPurchase()
        {
            return View();
        }
        public ActionResult PurchaseList()
        {
            return View();
        }


    }
}