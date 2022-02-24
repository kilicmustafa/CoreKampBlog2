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
    public class AboutManager : IAboutService
    {
        EfAboutRepository _aboutDal;

        public AboutManager(EfAboutRepository aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public List<About> GetAbout()
        {
            return _aboutDal.GetAllList();
        }
    }
}
