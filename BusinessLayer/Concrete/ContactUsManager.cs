using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ContactUsManager : IContactUsService
    {
        private IContactUsDal _contactUsDal;

        public ContactUsManager(IContactUsDal contactUsDal)
        {
            _contactUsDal = contactUsDal;
        }

        public void TAdd(ContactUs item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(ContactUs item)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(ContactUs item)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetList()
        {
            return _contactUsDal.GetList();
        }

        public ContactUs TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> GetByFilter(Expression<Func<ContactUs, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<ContactUs> TGetListContactUsByTrue()
        {
            return _contactUsDal.GetListContactUsByTrue();
        }

        public List<ContactUs> TGetListContactUsByFalse()
        {
            return _contactUsDal.GetListContactUsByFalse();
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            throw new NotImplementedException();
        }

        public void TContactUsStatusChangeToTrue(int id)
        {
            throw new NotImplementedException();
        }
    }
}
