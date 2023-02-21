using CloudCustomers.API.DBContext;
using CloudCustomers.API.Models;

namespace CloudCustomers.API.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetAllUsers();
    }

    public class UsersService : IUserService
    {
        UserDBContext userDBContext = new UserDBContext();
        public UsersService() { }

        public Task<List<User>> GetAllUsers()
        {
            var users = userDBContext.Users.OrderBy(user => user.Id);
            return users;
        }
    }
}
