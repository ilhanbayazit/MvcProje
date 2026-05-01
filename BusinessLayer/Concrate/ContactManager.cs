using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void AddContact(Contact contact)
        {
            _contactDal.insert(contact);
        }

        public void DeleteContact(Contact contact)
        {
            _contactDal.delete(contact);
        }

        public Contact GetByID(int id)
        {
            return _contactDal.Get(x => x.ContantID == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.list();
        }

        public void UpdateContact(Contact contact)
        {
            _contactDal.update(contact);
        }
    }
}
