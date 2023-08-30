using Microsoft.AspNetCore.Identity;

namespace Traversal_Booking.Models
{
    public class CustomIdentityValidator : IdentityErrorDescriber
    {
        public override IdentityError PasswordTooShort(int length)
        {
            return new IdentityError()
            {
                Code = "PasswordTooShort",
                Description = $"Password must be min. {length} charater!"
            };
        }
    }
}
