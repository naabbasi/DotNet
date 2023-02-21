using LearnEntityFramework.DBContext;
using LearnEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using WebMinimalApi.Localization;

namespace WebMinimalApi.Services;

public class UserService : IUserService
{
    private UserDBContext userDBContext;
    private IStringLocalizer<SharedResources> _localizer;

    public UserService([FromServices] UserDBContext userDBContext, [FromServices] IStringLocalizer<SharedResources> localizer)
    {
        this.userDBContext = userDBContext;
        this._localizer = localizer;
    }

    public async Task<IResult> GetUsers()
    {
        var users = await this.userDBContext
            .Users
            .OrderBy(user => user.Username)
            .ToListAsync();

        return Results.Ok(users);
    }

    public async Task<IResult> GetUserById(long userId)
    {
        var userById = await this.userDBContext
                .Users
                //.Include(user => user.GKey == userId)
                .SingleOrDefaultAsync(user => user.UserGkey == userId);

        if(userById == null) return Results.NotFound();

        return Results.Ok(userById);
    }

    public async Task<IResult> AddUser(User user)
    {
        this.userDBContext
            .Add(user);
        await this.userDBContext.SaveChangesAsync();

        return Results.Created($"/user/{user.UserGkey}", user.UserGkey);
    }

    public async Task<IResult> UpdateUser(User user)
    {
        var getSavedUser = await this.userDBContext.Users.FindAsync(user.UserGkey);

        if (getSavedUser is null) return Results.NotFound();

        getSavedUser.Username = user.Username;
        getSavedUser.Password = user.Password;

        await this.userDBContext.SaveChangesAsync();
        return Results.Accepted($"/user/{user.UserGkey}");
    }

    public async Task<IResult> DeleteUser(long userId)
    {
        if(await this.userDBContext.Users.FindAsync(userId) is User user)
        {
            this.userDBContext.Users.Remove(user);
            await this.userDBContext.SaveChangesAsync();

            return Results.Accepted($"/user/{userId}");
        }

        //return Results.NotFound();
        return Results.NoContent();
    }

    public async Task<IResult> SearchUser(string query)
    {
        if (query.Equals(string.Empty)) return Results.NotFound();

        var _selectedUsers = await this.userDBContext.Users.Where(user => user.Username.ToLower().Contains(query.ToLower())).ToListAsync();
        return _selectedUsers.Count > 0 ? Results.Ok(_selectedUsers) : Results.NotFound(Array.Empty<User>());
    }

    public async Task<IResult> GetUsers(int pageNumber, int pageSize)
    {
        /*await db.Books.Skip((pageNumber — 1) * pageSize)
        .Take(pageSize)
        .ToListAsync();*/
        List<User> users = new List<User>();
        return Results.Ok(users);
    }

    public string GetLocalizedMessage(string messageKey)
    {
        return this._localizer.GetString(messageKey);
    }
}
