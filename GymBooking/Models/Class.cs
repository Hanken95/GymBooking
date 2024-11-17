
using System.ComponentModel.DataAnnotations;

namespace GymBooking.Models
{
    public class Class
    {
        public  int Id { get; set; }
        public required string Name { get; set; } 
        public DateTime StartTime { get; set; } 
        public TimeSpan Duration { get; set; } 
        public DateTime EndTime { get { return StartTime + Duration; } } 
        public required string Description { get; set; }
        public ICollection<AppUserClass> AttendingUsers { get; set; }


    }
}
