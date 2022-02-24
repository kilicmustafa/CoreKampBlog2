using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager nlm = new NewsLetterManager(new EfNewsLetterRepository());

        

       
        [HttpPost]
        public ActionResult NewsLetterAddAction(NewsLetter newLetter)
        {
            newLetter.SubscriberStatus = true;
            nlm.Insert(newLetter);



            return RedirectToAction("Index", "Blog");
        }
    }
}
