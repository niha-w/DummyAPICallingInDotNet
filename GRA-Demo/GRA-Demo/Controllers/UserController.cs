using GRA_Demo.Models;
using GRA_Demo.Services;
using Microsoft.AspNetCore.Mvc;
namespace GRA_Demo.Controllers
{
    [Route("/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        UserService us = new UserService();

        //find user by their id
        [HttpGet("{userId}")]
        public async Task<IActionResult> GetUsersById(int userId)
        {
            var user = await us.GetUserById(userId);

            return Ok(user);
        }

        //find what devices assigned to user by userId
        [HttpGet("assignedDevicesTo/{userId}")]
        public async Task<IActionResult> GetAssignedDById(int userId)
        {
            var assigned = await us.GetAllDevicesByUser(userId);
            return Ok(assigned);
        }

        //update a user's team name
        [HttpPut("{userId}/team")]
        public async Task<IActionResult> UpdateUserTeam(int userId, string newTeamName)
        {
            var updated = await us.UpdateUserTeam(userId, newTeamName);

            return Ok("Team member added");
        }

        //add a user
        [HttpPost]
        public async Task<IActionResult> AddUser(User user)
        {
            var newUser = await us.AddUser(user.UserName, user.Designation, user.TeamName);
            return Ok(newUser);
        }
    }
}
