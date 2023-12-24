using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework;

public class EfContactUsDal : GenericRepository<ContactUs>, IContactUsDal
{
    public List<ContactUs> GetListContactUsByTrue()
    {
        using (var _context = new Context())
        {
            return _context.ContactUses.Where(c => c.MessageSatus == true).ToList();
        }

    }

    public List<ContactUs> GetListContactUsByFalse()
    {
        using (var _context = new Context())
        {
            return _context.ContactUses.Where(c => c.MessageSatus == false).ToList();
        }
    }

    public void ContactUsStatusChangeToFalse(int id)
    {
        throw new NotImplementedException();
    }

    public void ContactUsStatusChangeToTrue(int id)
    {
        throw new NotImplementedException();
    }
}