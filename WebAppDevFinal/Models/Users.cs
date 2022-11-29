using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDevFinal.Models
{
    public class Users
    {
        // EF will instruct the database to automatically generate this value
        public int UserID { get; set; }

        public string FirstName { get; set; }  

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

    }
}
