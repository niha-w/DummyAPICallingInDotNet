using GRA_Demo.Models;
namespace GRA_Demo.Models
{
    public class Assigned
    {
        public Devices Devices { get; set; }

        public User User { get; set; }

        public DateOnly DateGiven { get; set; }
    }
}
