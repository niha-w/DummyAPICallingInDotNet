namespace GRA_Demo.Models
{
    public class Session
    {
        public int SessionId { get; set; }
        public TimeSpan Duration { get; set; } // new TimeSpan(2, 30, 45) will give 2 hours, 30 minutes, 45 seconds

    }
}
