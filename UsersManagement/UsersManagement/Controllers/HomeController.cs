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
            if (ModelState.IsValid)
            {
                if ((loginForm.Username == "LUCA") && (loginForm.Password == "LUCA"))
                {

                    List<UserModel> users = new List<UserModel>();

                    for (int i = 0; i < 10; i++){
                        UserModel user = new UserModel();
                        user.Nome = "Nome " + (i + 1);
                        user.Cognome = "Cognome " + (i + 1);
                        user.Email = "Email " + (i + 1);
                        user.Username = "Username " + (i + 1);
                        user.Password = "Password " + (i + 1);
                    }

                    return View("Index",users);
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

	}
}