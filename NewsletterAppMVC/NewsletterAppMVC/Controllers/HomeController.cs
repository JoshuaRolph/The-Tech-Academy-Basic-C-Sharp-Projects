﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using NewsletterAppMVC.Models;


namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(string firstName, string lastName, string emailAddress)
        {

            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;
                    
                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }

                    return View("Success");
            }        
        }
    }
}