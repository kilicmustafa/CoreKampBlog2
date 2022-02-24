using DataAccessLayer.EntityFramework;

using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using EntityLayer.Concrete;

namespace CoreKampBlog2.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());

        public IActionResult Index()
        {

            var values = bm.GetAllListWithCategory();
            return View(values);
        }


        public IActionResult ReadMore(int id)
        {
            var value = bm.GetByIdWithCategory(id);



            return View(value);
        }

       

    }
}
