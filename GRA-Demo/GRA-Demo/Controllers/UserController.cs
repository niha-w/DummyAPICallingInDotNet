using GRA_Demo.Models;
using GRA_Demo.Services;
using Microsoft.AspNetCore.Mvc;
namespace GRA_Demo.Controllers
{
    [Route("/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService us = new ();
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUsersById(int userId)
        {
            var user = await us.GetUserById(userId);

            return Ok(user);
        }
    }
}
