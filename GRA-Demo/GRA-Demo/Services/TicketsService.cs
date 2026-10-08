using GRA_Demo.Models;
namespace GRA_Demo.Services
{
    public class TicketsService
    {
        private readonly List<Tickets> tickets = new()
        {
            new Tickets { TicketsId = 1, DevicesId = 101, Title = "Issue with Device A", Description = "Device A is not working properly.", Assigned = new Employee { EmployeeId = 1, EmpName = "John Doe", EmpDesignation = Employee.Designation.JrITHelp }, Assignee = new User { UserId = 1, UserName = "Alice", Designation = "Manager", TeamName = "Team A"}, Tstatus = Tickets.TStatus.Open },
            new Tickets { TicketsId = 2, DevicesId = 102, Title = "Issue with Device B", Description = "Device B is not responding.", Assigned = new Employee { EmployeeId = 2, EmpName = "Jane Smith", EmpDesignation = Employee.Designation.SrITHelp }, Assignee = new User { UserId = 2, UserName = "Bob", Designation = "Developer", TeamName = "Team B"}, Tstatus = Tickets.TStatus.WorkInProgress },
            new Tickets { TicketsId = 3, DevicesId = 103, Title = "Issue with Device C", Description = "Device C is overheating.", Assigned = new Employee { EmployeeId = 3, EmpName = "Bob Johnson", EmpDesignation = Employee.Designation.HeadOfIT }, Assignee = new User { UserId = 3, UserName = "Charlie", Designation = "Designer", TeamName = "Team C"}, Tstatus = Tickets.TStatus.Close }
        };

        public async Task<List<Tickets>> GetAllTickets()
        {
            return tickets;
        }

        public async Task<List<Tickets>> GetTicketsByStatus(Tickets.TStatus status)
        {
            return tickets.Where(t => t.Tstatus == status).ToList();
        }


    }
}
