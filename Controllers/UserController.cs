using Microsoft.AspNetCore.Mvc;
using Project.Context;
using Project.Models;

namespace Project.Controllers
{
    public class UserController : Controller
    {
        MyContext db = new MyContext();

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(User user)
        {
            var existEmail = db.Users.FirstOrDefault(u => u.Email == user.Email);
            if (existEmail != null)
            {
                ModelState.AddModelError("", "Email Already Exist");
                return View();
            }

            if (user != null && ModelState.IsValid)
            {
                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            ModelState.Remove("ConfirmPassword");

            if (user != null && ModelState.IsValid)
            {
                var existUser = db.Users.FirstOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                if (existUser != null)
                {
                    HttpContext.Session.SetInt32("UserId", existUser.UserId);
                    HttpContext.Session.SetString("UserEmail", existUser.Email);
                    return RedirectToAction("Index", "Product");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid Email or Password");
                }
            }
            return View();
        }
        [HttpPost]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}
