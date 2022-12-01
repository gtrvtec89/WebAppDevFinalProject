using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebAppDevFinal.Data
{
    public class Orders
    {
        public int Id { get; set; }

        public int UserID { get; set; } 

        public int Number { get; set; }

        public int Quantity { get; set; }

        public DateTime DatePlaced { get; set; }

        public int ProductID { get; set; }  
    }
}