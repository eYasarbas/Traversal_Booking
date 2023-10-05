using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete;

public class AppUserManager : IAppUserService
{
    private readonly IAppUserDal _appUserDal;

    public AppUserManager(IAppUserDal appUserDal)
    {
        _appUserDal = appUserDal;
    }

    public void TAdd(AppUser item)
    {
        throw new NotImplementedException();
    }

    public void TDelete(AppUser item)
    {
        throw new NotImplementedException();
    }

    public void TUpdate(AppUser item)
    {
        throw new NotImplementedException();
    }

    public List<AppUser> TGetList()
    {
        return _appUserDal.GetList();
    }

    public AppUser TGetById(int id)
    {
        throw new NotImplementedException();
    }

    public List<AppUser> GetByFilter(Expression<Func<AppUser, bool>> filter)
    {
        throw new NotImplementedException();
    }
}