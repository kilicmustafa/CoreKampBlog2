using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.Controllers
{
    public class ErrorPagesController : Controller
    {
        public IActionResult Error1(int code)
        {
            return View();
        }
    }
}
