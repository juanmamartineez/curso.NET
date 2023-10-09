using curso.NET.Models;
using Microsoft.AspNetCore.Mvc;
using UserService;

namespace curso.NET.Controllers
{
    [Route("Users")]
    public class UserController : Controller
    {
        [Route("")]
        public IActionResult Index()
        {
            User user = new User
            {
                Name = "Juan",
                LastName = "Martinez",
                Dni = 39323840,
                Age = 27
            };

            return View(user);
        }

        [Route("UsersService")]
        public async Task<IActionResult> UsersService()
        {
            List<User> users = new List<User>();
            var userService = new UserClient();

            var userList = await userService.GetUsersAsync();

            foreach (var user in userList)
            {
                users.Add(new User
                {
                    Name = user.Name,
                    LastName = user.LastName,
                    Dni = user.Dni,
                    Age = user.Age,
                });
            }

            return View("UsersFromService", users);
        }
    }
}
