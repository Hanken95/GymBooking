using Microsoft.AspNetCore.Identity;

namespace GymBooking.Models
{
    public class AppUser : IdentityUser<int>
    {
        public ICollection<AppUserClass> AttendedClasses { get; set; } = default;


    }
}
