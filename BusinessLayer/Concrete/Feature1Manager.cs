using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class Feature1Manager : IFeatureService
    {
        IFeatureDal _featureDal;
        public Feature1Manager(IFeatureDal featureDal)
        {
            _featureDal = featureDal;
        }

        public Feature GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void TAdd(Feature item)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Feature item)
        {
            throw new NotImplementedException();
        }

        public Feature TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Feature> TGetList()
        {
            return _featureDal.GetList();
        }

        public void TUpdate(Feature item)
        {
            throw new NotImplementedException();
        }
    }

}
