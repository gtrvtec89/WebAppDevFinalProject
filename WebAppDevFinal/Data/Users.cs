using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


namespace WebAppDevFinal.Data
{
    public class Users
    {
        public int Id { get; set; }

        public string FirstName { get; set; }  

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}