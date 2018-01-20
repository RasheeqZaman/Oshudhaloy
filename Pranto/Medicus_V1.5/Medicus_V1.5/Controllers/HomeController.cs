using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicus_V1._5.Controllers
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
        public ActionResult Table()
        {
            return View();
        }
        public ActionResult Button()
        {
            return View();
        }
        public ActionResult Chart()
        {
            return View();
        }
        public ActionResult Calender()
        {
            return View();
        }
        public ActionResult Form()
        {
            return View();
        }
        public ActionResult Gallery()
        {
            return View();
        }
        public ActionResult Panel()
        {
            return View();
        }
        public ActionResult General()
        {
            return View();
        }
        public ActionResult ToDoList()
        {
            return View();
        }
        public ActionResult ResponsiveTable()
        {
            return View();
        }
        public ActionResult AddMedicine()
        {
            return View();
        }
        public ActionResult AddSupplier()
        {
            return View();
        }
        public ActionResult ManageSupplier()
        {
            return View();
        }
        public ActionResult AddPurchase()
        {
            return View();
        }
        public ActionResult ManagePurchase()
        {
            return View();
        }
        public ActionResult ManageCategory()
        {
            return View();
        }
        public ActionResult AddCategory()
        {
            return View();
        }
        
    }
}