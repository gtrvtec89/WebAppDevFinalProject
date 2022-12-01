using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAppDevFinal.Data;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Controllers
{
    public class UserController : Controller
    {

        //private readonly ApplicationDbContext _context;
        private UserContext _user_context;

        //public UserController(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
        
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

                return View("~/Views/Home/index.cshtml");
            } 
            else {
                // model-level validation message
                ModelState.AddModelError("", "Please correct all errors.");
                return View("Index");
            }
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}