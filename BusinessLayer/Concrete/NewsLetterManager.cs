using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class NewsLetterManager : INewsLetterService
    {


        EfNewsLetterRepository _NewsLetterDal;

        public NewsLetterManager(EfNewsLetterRepository newsLetterDal)
        {
            _NewsLetterDal = newsLetterDal;
        }

        public void Insert(NewsLetter newsLetter)
        {
            _NewsLetterDal.Insert(newsLetter);
        }
    }
}
