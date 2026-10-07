using GRA_Demo.Models;

namespace GRA_Demo.Services
{
    public class UserService
    {
        private readonly List<User> users =
            [
                new User { UserId = 1, UserName = "Alice", Designation = "Manager", TeamName = "Team A", DeviceId = 101 },
                new User { UserId = 2, UserName = "Bob", Designation = "Developer", TeamName = "Team B", DeviceId = 102 },
                new User { UserId = 3, UserName = "Charlie", Designation = "Designer", TeamName = "Team C", DeviceId = 103 }
            ];

        public async Task<User> GetUserById (int userId)
        {
            return users.FirstOrDefault(u => u.UserId == userId);
        }
    }
}
