using GRA_Demo.Models;
namespace GRA_Demo.Models
{
    public class Tickets
    {
        public int TicketsId { get; set; }
        public int DevicesId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Employee Assigned { get; set; }
        public User Assignee { get; set; }
        public TStatus Tstatus { get; set; }

        public enum TStatus
        {
            Open, 
            Close,
            WorkInProgress
        }
    }
}
