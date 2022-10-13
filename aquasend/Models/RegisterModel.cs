using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace aquasend.Models
{
	public class RegisterModel
	{
		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }

		[Required]
		public string Password { get; set; }
		[Required]
		public string Email { get; set; }
		public string PhoneNumber { get; set; }
		public bool IsAdmin { get; set; }
		public bool IsDriver { get; set; }
	}
}
