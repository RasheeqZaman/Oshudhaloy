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

        public ActionResult CustomLogOut()
        {
            Session["ID"] = null;
            Session["Name"] = null;

            return RedirectToAction("Index", "Home");
        }


        public ActionResult CustomRegisterCustomer()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomRegisterCustomer(CustomRegisterViewModel viewModel)
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
                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }
        public ActionResult CustomRegisterAdmin()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CustomRegisterAdmin(CustomRegisterViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                Pharmacy p = new Pharmacy
                {
                    Name = viewModel.PharmacyName,
                    Address = viewModel.PharmacyAddress,
                    PhoneNumber = viewModel.PharmacyPhoneNumber
                };
                db.PharmacyTable.Add(p);
                db.SaveChanges();

                db.AdminTable.Add(new Admin
                {
                    UserName = viewModel.UserName,
                    Email = viewModel.Email,
                    Password = viewModel.Password,
                    Address = viewModel.Address,
                    PhoneNumber = viewModel.PhoneNumber,
                    PharmacyId = p.PharmacyId
                });
                db.SaveChanges();

                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }


        [HttpPost]
        public ActionResult CustomLogin(CustomLoginViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                Customers c = db.CustomerTable.SqlQuery("select * from customers where email = '" + viewModel.Email + "' and password = '" + viewModel.Password + "'").FirstOrDefault();
                if (c != null)
                {
                    Session["User"] = 1;
                    Session["UserName"] = "customers";
                    Session["ID"] = c.CustomersId;
                    Session["Name"] = c.UserName;
                }
                Admin a = db.AdminTable.SqlQuery("select * from admins where email = '" + viewModel.Email + "' and password = '" + viewModel.Password + "'").FirstOrDefault();
                if (a != null)
                {
                    Session["User"] = 2;
                    Session["UserName"] = "admin";
                    Session["ID"] = a.AdminId;
                    Session["Name"] = a.UserName;
                }

                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }


    }
}