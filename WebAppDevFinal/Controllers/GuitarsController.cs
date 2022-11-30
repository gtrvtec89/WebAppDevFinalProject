using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Controllers
{
    public class GuitarsController : Controller
    {
        private GuitarsContext data { get; set; }
        public GuitarsController(GuitarsContext ctx) => data = ctx;

        public ViewResult Index()
        {
            var guitars = data.Guitars.OrderBy(t => t.Brand).ToList();
            return View(guitars);
        }
    }
}