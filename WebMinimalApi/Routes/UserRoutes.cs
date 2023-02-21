using LearnEntityFramework.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using WebMinimalApi.Services;

namespace WebMinimalApi.Routes
{
    public class UserRoutes
    {
        private WebApplication webApplication;
        private String endpoint = "/api/user";

        public void AddUserRoutes(WebApplication webApplication) {
            this.webApplication = webApplication;
            SetupRoutes();
        }

        private void SetupRoutes()
        {
            this.webApplication.MapGet(endpoint, async (HttpRequest httpRequest, [FromServices] IUserService userService) => await AllUsers(httpRequest, userService))
                .Produces<List<User>>(StatusCodes.Status201Created)
                //.RequireCors(MyAllowSpecificOrigins)
                .WithName("GetAllUsers");

            this.webApplication.MapPost(endpoint, async ([FromBody] User user, [FromServices] IUserService userService) => await AddUser(user, userService))
                .Accepts<User>(MediaTypeNames.Application.Json)
                .Produces<User>(StatusCodes.Status201Created)
                .WithName("AddUser");

            this.webApplication.MapPut("/api/user", async (User user, [FromServices] IUserService userService) => await UpdateUser(user, userService))
                .Accepts<User>("application/json")
                .Produces<User>(StatusCodes.Status202Accepted)
                .WithName("UpdateUser");

            this.webApplication.MapDelete("/api/user/{userId}", async (long userId, [FromServices] IUserService userService) => await DeleteUser(userId, userService)).WithName("DeleteUser");
            this.webApplication.MapGet("/api/user/{userId}", async (long userId, [FromServices] IUserService userService) => await GetUserById(userId, userService)).WithName("GetUserById");
            this.webApplication.MapGet("/api/user/search/{query}", async (string query, [FromServices] IUserService userService) => await SearchUser(query, userService)).WithName("SearchUser");
        }

        public Task<IResult> AllUsers(HttpRequest httpRequest, IUserService userService)
        {
            userService.GetLocalizedMessage("test.username");
            return userService.GetUsers();
        }

        public Task<IResult> AddUser(User user, IUserService userService)
        {
            return userService.AddUser(user);
        }

        public Task<IResult> UpdateUser(User user, IUserService userService)
        {
            return userService.UpdateUser(user);
        }

        public Task<IResult> DeleteUser(long userId, IUserService userService)
        {
            return userService.DeleteUser(userId);
        }

        public Task<IResult> GetUserById(long userId, IUserService userService)
        {
            return userService.GetUserById(userId);
        }

        public Task<IResult> SearchUser(String query, IUserService userService)
        {
            return userService.SearchUser(query);
        }
    }
}
