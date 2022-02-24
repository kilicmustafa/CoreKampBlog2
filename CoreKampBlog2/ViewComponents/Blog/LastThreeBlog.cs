using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.ViewComponents.Blog
{
    public class LastThreeBlog : ViewComponent
    {

        public IViewComponentResult Invoke()
        {


            return View();
        }
    }
}
