using GRA_Demo.Models;
namespace GRA_Demo.Services
{
    public class AssignedService
    {
        public readonly List<Assigned> assignedDevices =
        [
            new Assigned
            {
                Devices = new Devices
                {
                    DevicesId = 1,
                    BrandName = "Dell Latitude 5440"
                },
                User = UserService.users[0],
                DateGiven = new DateOnly(2026, 1, 15)
            },

            new Assigned
            {
                Devices = new Devices
                {
                    DevicesId = 2,
                    BrandName = "HP EliteBook 840"
                },
                User = UserService.users[1],
                DateGiven = new DateOnly(2026, 2, 10)
            },

            new Assigned
            {
                Devices = new Devices
                {
                    DevicesId = 3,
                    BrandName = "Lenovo ThinkPad E14"
                },
                User = UserService.users[2],
                DateGiven = new DateOnly(2026, 3, 5)
            },

            new Assigned
            {
                Devices = new Devices
                {
                    DevicesId = 4,
                    BrandName = "Apple MacBook Pro"
                },
                User = UserService.users[0],
                DateGiven = new DateOnly(2026, 4, 20)
            },

            new Assigned
            {
                Devices = new Devices
                {
                    DevicesId = 5,
                    BrandName = "Dell XPS 15"
                },
                User = UserService.users[1],
                DateGiven = new DateOnly(2026, 5, 12)
            }
        ];
    }
}
