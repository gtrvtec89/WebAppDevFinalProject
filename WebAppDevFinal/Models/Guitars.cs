using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDevFinal.Models
{
    public class Guitars
    {
        // EF will instruct the database to automatically generate this value
        public int ProductID { get; set; }

        public string Brand { get; set; }

        public string Type { get; set; }

        public string Model { get; set; }

        public decimal Cost { get; set; }

        public decimal List { get; set; }

        public int Quantity { get; set; }
    }
}
