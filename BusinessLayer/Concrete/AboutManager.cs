using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{

    public class AboutManager : IAboutService
    {
        IAboutDal _aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public About GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(About item)
        {
            _aboutDal.Insert(item);
        }

        public void TDelete(About item)
        {
            _aboutDal.Delete(item);
        }

        public About TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> GetByFilter(Expression<Func<About, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
            return _aboutDal.GetList();
        }

        public void TUpdate(About item)
        {
            _aboutDal.Update(item);
        }

    }

}
