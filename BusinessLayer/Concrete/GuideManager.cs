using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete;

public class GuideManager : IGuideService
{
    private IGuideDal _guideDal;

    public GuideManager(IGuideDal guideDal)
    {
        _guideDal = guideDal;
    }

    public void TAdd(Guide item)
    {
        _guideDal.Insert(item);
    }

    public void TDelete(Guide item)
    {
        _guideDal.Delete(item);
    }

    public void TUpdate(Guide item)
    {
        _guideDal.Update(item);
    }

    public List<Guide> TGetList()
    {
        return _guideDal.GetList();
    }

    public Guide TGetById(int id)
    {
        return _guideDal.GetByID(id);
    }

    public List<Guide> GetByFilter(Expression<Func<Guide, bool>> filter)
    {
        throw new NotImplementedException();
    }
}