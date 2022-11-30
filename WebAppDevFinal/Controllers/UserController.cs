using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Controllers
{
    public class UserController : Controller
    {
        private UsersContext data { get; set; }
        public UserController(UsersContext ctx) => data = ctx;

        [HttpGet]
        public ViewResult Add() => View(new Users());
        
        [HttpPost]
        public IActionResult Add(Users users)
        {
            // server-side check for remote validation for duplicate date
            Users check = data.Users.FirstOrDefault(t => t.Email == users.Email);
            if (check != null) { 
                ModelState.AddModelError("Email",
                    $"The User {users.Email} is already in the database.");
            }

            if (ModelState.IsValid) {
                data.Users.Add(users);
                data.SaveChanges();

                return View("~/Views/Home/index.cshtml");
            } 
            else {
                // model-level validation message
                ModelState.AddModelError("", "Please correct all errors.");
                return View(users);
            }
        }
    }
}