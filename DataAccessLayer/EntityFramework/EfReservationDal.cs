using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.EntityFramework;

public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
{
    public List<Reservation> GetListWithReservationByWaitApproval(int id)
    {
        using var context = new Context();
        return context.Reservations.Include(x => x.Destination)
            .Where(y => y.Status != null && y.Status.Equals("Pending") && y.AppUserId == id).ToList();
    }

    public List<Reservation> GetListWithReservationByWaitAccepted(int id)
    {
        using var context = new Context();
        return context.Reservations.Include(x => x.Destination)
            .Where(y => y.Status != null && y.Status.Equals("Confirmed") && y.AppUserId == id).ToList();

    }

    public List<Reservation> GetListWithReservationByWaitPrevious(int id)
    {
        using var context = new Context();
        return context.Reservations.Include(x => x.Destination)
            .Where(y => y.Status != null && y.Status.Equals("Previous") && y.AppUserId == id).ToList();
    }
}