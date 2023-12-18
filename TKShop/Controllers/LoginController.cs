using Microsoft.AspNetCore.Mvc;

namespace TKShop.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
