using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete
{
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationDal;

        public ReservationManager(IReservationDal reservationDal)
        {
            _reservationDal = reservationDal;
        }

        public void TAdd(Reservation item)
        {
            _reservationDal.Insert(item);
        }

        public void TDelete(Reservation item)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetByFilter(Expression<Func<Reservation, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            return _reservationDal.GetListWithReservationByWaitApproval(id);
        }

        public List<Reservation> GetListWithReservationByWaitAccepted(int id)
        {
            return _reservationDal.GetListWithReservationByWaitAccepted(id);
        }

        public List<Reservation> GetListWithReservationByWaitPrevious(int id)
        {
            return _reservationDal.GetListWithReservationByWaitPrevious(id);
        }


        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation item)
        {
            throw new NotImplementedException();
        }
    }
}
