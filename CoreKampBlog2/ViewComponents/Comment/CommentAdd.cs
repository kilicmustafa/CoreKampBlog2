using Microsoft.AspNetCore.Mvc;

namespace CoreKampBlog2.ViewComponents.Comment
{
    public class CommentAdd : ViewComponent
    {


        public IViewComponentResult Invoke()
        {


            return View();
        }

    }
}
