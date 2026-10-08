using GRA_Demo.Models;
using GRA_Demo.Services;
using Microsoft.AspNetCore.Mvc;
namespace GRA_Demo.Controllers
{
    [Route("/tickets")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        TicketsService ts = new TicketsService();
        [HttpGet]
        public async Task<IActionResult> GetAllTickets()
        {
            var allTickets = await ts.GetAllTickets();
            return Ok(allTickets);
        }

        [HttpGet("status/{status}")]
        public async Task<IActionResult> GetAllTicketsByStatus(Tickets.TStatus status)
        {
            var t = await ts.GetTicketsByStatus(status);
            return Ok(t);
        }
    }
}
