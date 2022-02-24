using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCommentRepository : GenericRepository<Comment>, ICommentDal
    {
        Context c = new Context();
        public List<Comment> GetListWithBlog(int id)
        {
            var values = c.Set<Comment>().Where(x => x.BlogId == id).ToList();

            return values;

        }
    }
}
