using CloudCustomers.API.Models;

namespace CloudCustomers.UnitTests.Fixture
{
    public static class UserFixture
    {
        public static List<User> GetTestUsers() => new() {
            new User{
                Name = "Test User 1",
                Email = "nabbasi@QTerminals.com",
                Address = new Address
                {
                    Street = "Al Atheer",
                    City = "Somewhere",
                    ZipCode = 123123
                }
            },
            new User{
                Name = "Test User 2",
                Email = "nabbasi@QTerminals.com",
                Address = new Address
                {
                    Street = "Al Atheer",
                    City = "Somewhere",
                    ZipCode = 123123
                }
            }
        };
    }
}
