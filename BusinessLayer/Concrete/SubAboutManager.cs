using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class SubAboutManager : ISubAboutService
    {
        ISubAboutDal _subAboutDal;
        public SubAboutManager(ISubAboutDal subAboutDal)
        {
            _subAboutDal = subAboutDal;
        }
        public SubAbout GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(SubAbout item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout item)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> GetByFilter(Expression<Func<SubAbout, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<SubAbout> TGetList()
        {
            return _subAboutDal.GetList();
        }

        public void TUpdate(SubAbout item)
        {
            throw new NotImplementedException();
        }
    }

}
