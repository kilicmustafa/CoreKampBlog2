using BusinessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {

        EfCommentRepository _CommentDal;

        public CommentManager(EfCommentRepository commentDal)
        {
            _CommentDal = commentDal;
        }

        public void Delete(Comment comment)
        {
            _CommentDal.Delete(comment);
        }

        public List<Comment> GetAllList()
        {
            return _CommentDal.GetAllList();
        }

        public Comment GetById(int id)
        {
            return _CommentDal.GetById(id);
        }

        public List<Comment> GetListWithBlog(int id)
        {
            return _CommentDal.GetListWithBlog(id);
        }

        public void Insert(Comment comment)
        {
           _CommentDal.Insert(comment);
        }

        public void Update(Comment comment)
        {
            _CommentDal.Update(comment);
        }
    }
}
