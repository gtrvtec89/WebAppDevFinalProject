using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAppDevFinal.Data;
using WebAppDevFinal.Models;

namespace WebAppDevFinal.Controllers
{
    public class OrdersController : Controller
    {
        
        private ApplicationDbContext data { get; set; }
        public OrdersController(ApplicationDbContext ctx) => data = ctx;

        public ViewResult Index()
        {
            var orders = data.Orders.ToList();
            var model = new GuitarOrderViewModel
            {
                Orders = orders
            };
            return View(model);
        }
        
        public IActionResult OrdersSuccess()
        {
            return View(OrdersSuccess());
        }
        public IActionResult Add(int quantity, int product )
        {
            Order model = new Order();
            model.Number = quantity;
            model.ProductID = product;
            model.UserID = 1;
            model.DatePlaced = DateTime.Now;
            model.Quantity = quantity;

            data.Orders.Add(model);
            data.SaveChanges();
            return View("OrdersSuccess");
        }
        
    }
}