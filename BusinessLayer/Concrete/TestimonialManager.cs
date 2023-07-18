using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class TestimonialManager : ITestimonalService
    {
        ITestimonalDal _testimonalDal;
        public TestimonialManager(ITestimonalDal testimonalDal)
        {
            _testimonalDal = testimonalDal;
        }
        public Testimonal GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Testimonal item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonal item)
        {
            throw new NotImplementedException();
        }

        public Testimonal TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Testimonal> TGetList()
        {
            return _testimonalDal.GetList();
        }

        public void TUpdate(Testimonal item)
        {
            throw new NotImplementedException();
        }
    }

}
