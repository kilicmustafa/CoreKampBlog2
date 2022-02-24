using BusinessLayer.Concrete;

using EntityLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.ViewComponents.NewsLetter
{
    public class AddNewsLetter : ViewComponent
    {
        NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterRepository());


      
        public IViewComponentResult Invoke()
        {

          

            return View();
        }
    }
}
