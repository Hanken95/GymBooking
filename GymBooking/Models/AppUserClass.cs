namespace GymBooking.Models
{
    public class AppUserClass
    {
        public int UserId { get; set; }
        public int ClassId { get; set; }

        public AppUser User { get; set; }
        public Class Class { get; set; }
    }
}
