using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAppDevFinal.Data;

namespace WebAppDevFinal.Controllers
{
    public class UserController : Controller
    {
     
            private readonly ApplicationDbContext _context;

            public UserController(ApplicationDbContext context)
            {
                _context = context;
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
        public IActionResult Add(Users users)
        {
            // server-side check for remote validation for duplicate date
            Users check = _context.Users.FirstOrDefault(t => t.Email == users.Email);
            if (check != null) { 
                ModelState.AddModelError("Email",
                    $"The User {users.Email} is already in the database.");
            }

            if (ModelState.IsValid) {
                _context.Users.Add(users);
                _context.SaveChanges();

                return View("~/Views/Home/index.cshtml");
            } 
            else {
                // model-level validation message
                ModelState.AddModelError("", "Please correct all errors.");
                return View("Index");
            }
        }
    }
}