using System.ComponentModel.DataAnnotations;

namespace Traversal_Booking.Models;

public class UserSignInViewModel
{
    [Required(ErrorMessage = "Please enter your Username")]
    public string UserName { get; set; }


    [Required(ErrorMessage = "Please enter your password")]
    public string Password { get; set; }
}