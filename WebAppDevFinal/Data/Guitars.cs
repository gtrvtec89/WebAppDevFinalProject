using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebAppDevFinal.Data
{
    public class Guitars
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public string Model { get; set; }

        public decimal Cost { get; set; }

        public decimal List { get; set; }

        public int Quantity { get; set; }
    }
}