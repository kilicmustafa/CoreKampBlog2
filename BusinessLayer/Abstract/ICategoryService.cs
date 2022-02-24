using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void Insert(Category category);
        void Update(Category category);

        void Delete(Category category);

        List<Category> GetAllList();

        Category GetCategoryById(int id);
        

    }
}
