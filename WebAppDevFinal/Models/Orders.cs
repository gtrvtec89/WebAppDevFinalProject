using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDevFinal.Models
{
    public class Orders
    {
        // EF will instruct the database to automatically generate this value
        public int OrderID { get; set; }

        public int CustomerID { get; set; } 

        public int Number { get; set; }

        public int Quantity { get; set; }

        public DateTime DatePlaced { get; set; }

        public DateTime DateReceived { get; set; }

        public int ProductID { get; set; }  // forign key
    }
}
