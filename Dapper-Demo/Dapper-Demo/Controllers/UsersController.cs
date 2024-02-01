using Microsoft.AspNetCore.Mvc;

namespace Dapper_Demo.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
