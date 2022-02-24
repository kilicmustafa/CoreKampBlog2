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
    public class ContactManager : IContactService

    {

        EfContactRepository _contactDal;

        public ContactManager(EfContactRepository contactDal)
        {
            _contactDal = contactDal;
        }

        public List<Contact> GetAllList()
        {
            return _contactDal.GetAllList();
        }

        public void Insert(Contact contact)
        {
            _contactDal.Insert(contact);
        }
    }
}
