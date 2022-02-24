using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.Controllers
{
    public class ContactController : Controller
    {

        ContactManager cm = new ContactManager(new EfContactRepository());
        public IActionResult Index()
        {
            return View();
        }

    

        [HttpPost]
        public IActionResult ContactAdd(Contact contact)
        {

            cm.Insert(contact);



            return View();
        }
    }
}
