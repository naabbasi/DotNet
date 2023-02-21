using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace WebApiControllerBased.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class UserController : ControllerBase
    {
        private SecurityService _securityService;

        public UserController(SecurityService securityService)
        {
            this._securityService = securityService;
        }

        private static User[] users = new User[]
        {
            new User(){
                UserGenericKey = 1, Username = "nabbasi", Password = "x"
            },
            new User(){
                UserGenericKey = 2, Username = "fabbasi", Password = "x"
            },
            new User(){
                UserGenericKey = 3, Username = "aabbasi", Password = "x"
            }
        };

        [HttpGet]
        [Produces(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(User))]
        public IActionResult Index()
        {
            this._securityService.GetUserInfo();
            var alUsers = Task.FromResult<User[]>(users);
            return Ok(alUsers.Result);
        }

        [HttpPost]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Save(User user)
        {
            return Created("/api/user", user);
        }

        [HttpPut]
        [Consumes(MediaTypeNames.Application.Json)]
        public IActionResult Edit(User user)
        {
            for(int i = 0; i < users.Length; i++){
                if (users[i].UserGenericKey == user.UserGenericKey)
                {
                    users[i] = user;
                }
            }

            return Accepted("/api/user", user);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            for (int i = 0; i < users.Length; i++)
            {
                if (users[i].UserGenericKey == id)
                {
                    users[i] = null;
                }
            }

            return Accepted("/api/user", id);
        }
    }
}
