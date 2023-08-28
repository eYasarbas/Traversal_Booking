using Microsoft.AspNetCore.Authorization;

namespace Traversal_Booking.Areas.Member.Models
{
    [AllowAnonymous]
    public class UserEditViewModel
    {
        public string name { get; set; }
        public string surname { get; set; }
        public string yourAbout { get; set; }
        public string password { get; set; }
        public string confirmpassword { get; set; }
        public string imageUrl { get; set; }
        public string phoneNumber { get; set; }
        public string mail { get; set; }
        public IFormFile Image { get; set; }
    }
}
