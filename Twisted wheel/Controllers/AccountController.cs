using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TwistedWheel.Models;

namespace Twisted_wheel.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
                return View(new User());
        }

        [HttpPost]
        public IActionResult SignIn(User user)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", new { Username = user.Username });
            }
            else
            {
                return View(user);
            }
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View(new User());
        }

        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            //if (ModelState.IsValid)
            //{
            //    return RedirectToAction("Index", new { Username = user.Username });
            //}
            //else
            //{
            //    return View(user);
            //}

            if (user.Password == verify && !String.IsNullOrEmpty(user.Username))
            {
                // return RedirectToAction("Index", user);
                return RedirectToAction("Index", new { Username = user.Username });
            }
            else
            {
                ViewBag.PasswordError = user.Password != verify ? "Your passwords must match" : "";
                ViewBag.UsernameError = String.IsNullOrEmpty(user.Username) ? "You must enter a username" : "";
                return View(user);
            }
        }

        public IActionResult SignOut()
        {
            return View();
        }

        
    }
}