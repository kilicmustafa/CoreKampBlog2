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
    public class BlogManager : IBlogService
    {

        EfBlogRepository _BlogDal;

        public BlogManager(EfBlogRepository blogDal)
        {
            _BlogDal = blogDal;
        }

        public void Delete(Blog blog)
        {
            _BlogDal.Delete(blog); 
        }

        public List<Blog> GetAllList()
        {
            return _BlogDal.GetAllList();
        }

        public List<Blog> GetAllListWithCategory()
        {
            return _BlogDal.GetAllListWithCategory();
        }

        public List<Blog> GetBlogByWriter(int id)
        {
            return _BlogDal.GetBlogByWriter(id);
        }

        public Blog GetByIdWithCategory(int id)
        {
            return _BlogDal.GetByIdWithCategory(id);
        }

        public Blog GetCategoryById(int id)
        {
            return _BlogDal.GetById(id);
        }

        public void Insert(Blog blog)
        {
            _BlogDal.Insert(blog);
        }

        public void Update(Blog blog)
        {
            _BlogDal.Update(blog);
        }
    }
}
