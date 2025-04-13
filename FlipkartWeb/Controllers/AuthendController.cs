using FlipkartWeb.Helper;
using FlipkartWeb.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace FlipkartWeb.Controllers
{
    public class AuthendController : Controller
    {
        private const string UserSessionKey = "UserSession";
        private readonly EmailService _emailService;


        private static List<AuthendModel> _users = new List<AuthendModel>(); // Simulates a database
        private readonly AppDBContext appDBContextobj;

        public AuthendController(AppDBContext appDBContext)
        {
            appDBContextobj = appDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult login()
        {
            return View();

        }

        [HttpGet]
        public IActionResult Registration()
        {
           return View(new AuthendModel());
            //return View();
        }

        [HttpPost]

        public IActionResult Registrationpost(AuthendModel data)
        {
            var Auth = appDBContextobj.authendModels.ToList();
            var single = Auth.Where(x => x.Emailid == data.Emailid).FirstOrDefault();
            if (single == null)
            {
                appDBContextobj.authendModels.Add(data);
                appDBContextobj.SaveChanges();
                return RedirectToAction("Login");
            }
            else
            {
                ViewBag.Message = "Email already registered!";
                return View("Registration");
            }
        }

        [HttpPost]
        public IActionResult loginpost(AuthendModel data)
        {
            var Auth = appDBContextobj.authendModels.ToList();
            var single = Auth.Where(x => x.Emailid == data.Emailid).FirstOrDefault();
            if (single != null)
            {
                return RedirectToAction("Index", "Home");
            }
        
            else
            {
                ViewBag.Message = "Invalid Email ID and password";
                return View("Login");
            }

        }
        //public IActionResult Login(AuthendModel data)
        //{
        //    appDBContextobj.authendModels.Add(data);
        //    appDBContextobj.SaveChanges();
        //    return View("Login", data);
        //}

        public IActionResult Logout()
        {
            HttpContext.Session.Remove(UserSessionKey);
            return RedirectToAction("Login");
        }
    }
}

