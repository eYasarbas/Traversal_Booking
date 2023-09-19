using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete;

public class DestinationManager : IDestinationService
{
    IDestinationDal _destinationDal;

    public DestinationManager(IDestinationDal destinationDal)
    {
        _destinationDal = destinationDal;
    }


    public void TAdd(Destination item)
    {
        _destinationDal.Insert(item);
    }

    public void TDelete(Destination item)
    {
        _destinationDal.Delete(item);
    }

    public List<Destination> TGetList()
    {
        return _destinationDal.GetList();
    }

    public void TUpdate(Destination item)
    {
        _destinationDal.Update(item);
    }


    public Destination TGetById(int id)
    {
        return _destinationDal.GetByID(id);
    }

    public List<Destination> GetByFilter(Expression<Func<Destination, bool>> filter)
    {
        throw new NotImplementedException();
    }
}