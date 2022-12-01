using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppDevFinal.Data;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Controllers
{
    public class GuitarsController : Controller
    {
        
        /*private readonly ApplicationDbContext _context;

        public GuitarsController(ApplicationDbContext context)
        {
            _context = context;
        }*/
        private ApplicationDbContext data { get; set; }
        public GuitarsController(ApplicationDbContext ctx) => data = ctx;

        public ViewResult Index()
        {
            var guitars = data.Guitars.ToList();
            return View(guitars);
        }
    }
}