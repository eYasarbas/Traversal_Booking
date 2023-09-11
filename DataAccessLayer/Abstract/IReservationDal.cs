using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IReservationDal : IGenericDal<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByWaitAccepted(int id);
        List<Reservation> GetListWithReservationByWaitPrevious(int id);
    }
}
