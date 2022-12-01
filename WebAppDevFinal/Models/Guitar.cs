using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDevFinal.Models
{
    public class Guitar
    {
		// EF will instruct the database to automatically generate this value
		[Required]
		public int Id { get; set; }
		[Required]
		public string Brand { get; set; }
		[Required]
		public string Type { get; set; }
		[Required]
		public string Model { get; set; }
		[Required]
		public decimal Cost { get; set; }
		[Required]
		public decimal List { get; set; }
		[Required]
		public int Quantity { get; set; }
    }
}
