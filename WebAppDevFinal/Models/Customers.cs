using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDevFinal.Models
{
    public class Customers
    {
        // EF will instruct the database to automatically generate this value
        public int CusomterID { get; set; }

        public int UserID { get; set; }  // foreign key property

    }
}
