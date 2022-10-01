using Microsoft.AspNetCore.Mvc;

namespace CoreBlogMvc.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Error1(int code)
        {

            return View();
        }
    }
}
