using System.ComponentModel.DataAnnotations;

namespace DAL.Models
{
	internal class Users
	{
		public int user_id { get; set; }

		[Required(ErrorMessage = "User Name is Required !!")]
		public string name { get; set; }

		[Required(ErrorMessage = "Password is Required !!")]
		public string password { get; set; }

		//public string role_id { get; set; } //fk

	}
}
