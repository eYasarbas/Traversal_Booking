
using System.ComponentModel.DataAnnotations;

namespace Traversal_Booking.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage = "Please enter your name")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Please enter your surname")]
		public string SurName { get; set; }

		[Required(ErrorMessage = "Please enter your Username")]
		public string UserName { get; set; }

		[Required(ErrorMessage = "Please enter your mail adress")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Please enter your password")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Please a enter your password again")]
		[Compare("Password", ErrorMessage = "Password is no   t same")]
		public string ConfirmPassword { get; set; }

	}
}
