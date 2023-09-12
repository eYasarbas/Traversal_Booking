using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IReservationService : IGenericService<Reservation>
    {
        List<Reservation> GetListWithReservationByWaitApproval(int id);
        List<Reservation> GetListWithReservationByWaitAccepted(int id);
        List<Reservation> GetListWithReservationByWaitPrevious(int id);
    }
}
