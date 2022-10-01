using Microsoft.AspNetCore.Mvc;

namespace CoreBlogMvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
