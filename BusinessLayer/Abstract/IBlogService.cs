using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBlogService
    {

        void Insert(Blog blog);
        void Update(Blog blog);

        void Delete(Blog blog);

        List<Blog> GetAllList();

        Blog GetCategoryById(int id);

        List<Blog> GetAllListWithCategory();

        Blog GetByIdWithCategory(int id);


        List<Blog> GetBlogByWriter(int id);
    }
}
