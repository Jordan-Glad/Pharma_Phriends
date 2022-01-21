using Microsoft.AspNetCore.Mvc;

namespace Pharma_Phriends.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
