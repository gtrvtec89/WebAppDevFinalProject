using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppDevFinal.Models
{
    public class Order
    {
		// EF will instruct the database to automatically generate this value
		[Required]
		public int Id { get; set; }
		[Required]
		public int UserID { get; set; }
		[Required]
		public int Number { get; set; }
		[Required]
		public int Quantity { get; set; }
		[Required]
		public DateTime DatePlaced { get; set; }
		[Required]
		public int ProductID { get; set; }  // forign key
    }
}
