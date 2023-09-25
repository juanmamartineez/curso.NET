using curso.NET.Models;
using Microsoft.AspNetCore.Mvc;

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
                Edad = 27
            };

            return View(user);
        }
    }
}
