using LearnEntityFramework.Models;

namespace WebMinimalApi.Services;

public interface IUserService : IService
{
    Task<IResult> GetUsers();
    Task<IResult> GetUserById(long userId);
    Task<IResult> AddUser(User user);
    Task<IResult> UpdateUser(User user);
    Task<IResult> DeleteUser(long userId);
    Task<IResult> SearchUser(string query);
    Task<IResult> GetUsers(int pageNumber, int pageSize);
}
