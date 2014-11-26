using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UsersManagement.Models;

namespace UsersManagement.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginForm loginForm)
        {
            if ((loginForm.Username == "LUCA") && (loginForm.Password == "LUCA"))
            {

            }
            return View();
        }

	}
}