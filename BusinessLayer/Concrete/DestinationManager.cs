using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class DestinationManager : IDestinationService
	{
		IDestinationDal _destinationDal;
		public DestinationManager(IDestinationDal destinationDal)
		{
			_destinationDal = destinationDal;

		}



		public void TAdd(Destination item)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Destination item)
		{
			throw new NotImplementedException();
		}

		public List<Destination> TGetList()
		{
			return _destinationDal.GetList();
		}

		public void TUpdate(Destination item)
		{
			throw new NotImplementedException();
		}

		public Destination GetById(int id)
		{
			throw new NotImplementedException();
		}

		public Destination TGetById(int id)
		{
			return _destinationDal.GetByID(id);
		}
	}

}
