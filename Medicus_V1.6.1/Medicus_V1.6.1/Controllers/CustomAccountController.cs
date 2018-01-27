using Medicus_V1._6._1.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Medicus_V1._6._1.Controllers
{
    public class CustomAccountController : Controller
    {
        PharmacyContext db = new PharmacyContext();
        // GET: CustomAccount
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CustomRegister()
        {
            return View();
        }

        public ActionResult CustomLogin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomRegister(CustomRegisterViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                db.CustomerTable.Add(new Customers
                {
                    UserName = viewModel.UserName,
                    Email = viewModel.Email,
                    Password = viewModel.Password,
                    Address = viewModel.Address,
                    PhoneNumber = viewModel.PhoneNumber
                });
                db.SaveChanges();
            }

            return View(viewModel);
        }


        [HttpPost]
        public ActionResult CustomLogin(CustomLoginViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                Customers c = db.CustomerTable.SqlQuery("select * from customers where email = '" + viewModel.Email + "' and password = '" + viewModel.Password + "'").First();
                Session["ID"] = c.CustomersId;
                Session["Name"] = c.UserName;
            }

            return View(viewModel);
        }
    }
}