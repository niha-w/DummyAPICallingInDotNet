using GRA_Demo.Models;
using GRA_Demo.Services;
namespace GRA_Demo.Services
{
    public class UserService
    {
        public static readonly List<User> users =
            [
                new User { UserId = 1, UserName = "Alice", Designation = "Manager", TeamName = "Team A" },
                new User { UserId = 2, UserName = "Bob", Designation = "Developer", TeamName = "Team B" },
                new User { UserId = 3, UserName = "Charlie", Designation = "Designer", TeamName = "Team C" }
            ];

        AssignedService a = new AssignedService();

        public async Task<User> GetUserById (int userId)
        {
            return users.FirstOrDefault(u => u.UserId == userId);
        }

        public User GetusersAtIndex(int index)
        {
            return users[index];
        }

        public async Task<List<Assigned>> GetAllDevicesByUser(int userId)
        {
            return a.assignedDevices.Where(a => a.User.UserId == userId).ToList();
            // why ToListAsync() and await dont work??
        }

        public Task<bool> UpdateUserTeam(int userId, string newTeamName)
        {
            var user = users.FirstOrDefault(u => u.UserId == userId);

            if (user == null)
                return Task.FromResult(false);

            user.TeamName = newTeamName;
            return Task.FromResult(true);
        }

        public Task<User> AddUser(string userName, string designation, string teamName)
        {
            int newUserId = users.Max(u => u.UserId) + 1;

            var newUser = new User
            {
                UserId = newUserId,
                UserName = userName,
                Designation = designation,
                TeamName = teamName
            };

            users.Add(newUser);

            return Task.FromResult(newUser);
        }
    }
}
