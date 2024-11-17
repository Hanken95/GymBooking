namespace GymBooking.Models.ViewModels
{
    public class CreateClassViewModel
    {
        public required string Name { get; set; }
        public DateTime StartTime { get; set; }
        public TimeSpan Duration { get; set; }
        public required string Description { get; set; }
    }
}
