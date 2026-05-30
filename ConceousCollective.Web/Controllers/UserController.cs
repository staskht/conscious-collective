using Microsoft.AspNetCore.Mvc;

namespace ConceousCollective.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
