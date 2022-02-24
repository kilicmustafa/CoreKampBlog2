using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.Controllers
{
    public class CommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        CommentManager cm = new CommentManager(new EfCommentRepository());
     

        [HttpGet]
        public PartialViewResult CommentAddAction()
        {


            return PartialView();

        }

        [HttpPost]

        public IActionResult CommentAddAction(Comment comment)
        {
            comment.CommentDate = System.DateTime.Today;
            comment.CommentStatus = true;
            comment.BlogId = 7;
            


            cm.Insert(comment);

            string blogId = comment.BlogId.ToString();
            return RedirectToAction("ReadMore", "Blog", blogId);
        }
    }
}
