﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RegistrationForm.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {

            if (Session["UserId"] == null)
            {
                TempData["Login"] = "<script>alert('Plz..Login account!!')</script>";
                return RedirectToAction("Index", "User");

            }
            else
            {
          
                return View();


            }
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "User");
        }
    }
}