using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {

        Context c = new Context();
        public List<Blog> GetAllListWithCategory()
        {
            return c.Set<Blog>().Include(x => x.Category).ToList();
        }

        public List<Blog> GetBlogByWriter(int id)
        {
            return c.Set<Blog>().Where(x => x.WriterId == id).ToList();
        }

        public Blog GetByIdWithCategory(int id)
        {
            return c.Set<Blog>().Where(y => y.BlogId == id).Include(x => x.Category).FirstOrDefault();
        }
    }
}
