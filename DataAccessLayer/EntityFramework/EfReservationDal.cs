using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;

namespace DataAccessLayer.EntityFramework
{
    public class EfReservationDal : GenericRepository<Reservation>, IReservationDal
    {
        public List<Reservation> GetListWithReservationByWaitApproval(int id)
        {
            throw new NotImplementedException();

        }

        public List<Reservation> GetListWithReservationByWaitAccepted(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> GetListWithReservationByWaitPrevious(int id)
        {
            throw new NotImplementedException();
        }
    }
}
