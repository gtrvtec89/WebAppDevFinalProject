using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebAppDevFinal.Data;
//using WebAppDevFinal.Migrations.User;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Controllers
{
    public class UserController : Controller
    {
        private UserContext _user_context;

        public UserController(UserContext userContext)
        {
            _user_context = userContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Add(User users)
        {
            // server-side check for remote validation for duplicate date
            User check = _user_context.Users.FirstOrDefault(t => t.Email == users.Email);
            if (check != null) { 
                ModelState.AddModelError("Email",
                    $"The User {users.Email} is already in the database.");
            }

            if (ModelState.IsValid) {
                _user_context.Users.Add(users);
                _user_context.SaveChanges();

                return RedirectToAction("Index", "Home");
                //return View("Index");
            } 
            else {
                // model-level validation message
                ModelState.AddModelError("", "Please correct all errors.");
                return View("Add");
            }
        }
        [HttpGet]
        public IActionResult Login()
        {
           return View();
        }
        [HttpPost]
        public IActionResult Login(User user)
        {

            var usercredentials = _user_context.Users.FirstOrDefault(x => x.Email == user.Email && x.Password == user.Password);

            if (usercredentials == null)
            {
                return View("FailedLogin");
            }
            return View("LoginSuccess");
        }
	    [HttpGet]
        public IActionResult LoginSuccess()
        {
            return View();
        }

    }
}