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
    public class CategoryManager : ICategoryService
    {
        EfCategoryRepository _CategoryDal;

        public CategoryManager(EfCategoryRepository categoryDal)
        {
            _CategoryDal = categoryDal;
        }

        public void Delete(Category category)
        {
            _CategoryDal.Delete(category);
        }

        public List<Category> GetAllList()
        {
            return _CategoryDal.GetAllList();
        }

        public Category GetCategoryById(int id)
        {
            return _CategoryDal.GetById(id);
        }

        public void Insert(Category category)
        {
            _CategoryDal.Insert(category);
        }

        public void Update(Category category)
        {
            _CategoryDal.Update(category);
        }
    }
}
