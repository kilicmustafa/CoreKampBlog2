using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.Controllers
{
    public class AboutController : Controller
    {

        AboutManager am = new AboutManager(new EfAboutRepository());

        public IActionResult Index()
        {

            var values = am.GetAbout();

            return View(values);
        }
    }
}
