using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Softlock_Solutions.Models;

namespace Softlock_Solutions.Controllers
{
    public class LoginController : Controller
    {
        SoftlockSolutionsContext db = new SoftlockSolutionsContext();
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(String email,String password)
        {
            var user = db.LoginData.Where(a => a.Email.Equals(email) && a.Password.Equals(password));
            if (user.Count() == 1)
            {
                return RedirectToAction("Index", "Home");
            }

            return View();

        }

        public IActionResult createAccount()
        {
            return View();
        }

        [HttpPost]
        public IActionResult createAccount(LoginDatum userCreated)
        {
            if (ModelState.IsValid)
            {
                db.LoginData.Add(userCreated);
                db.SaveChanges();
                return RedirectToAction("Login");
            }

            return View();
        }
    }
}
