using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void TAdd(Comment item)
		{
			_commentDal.Insert(item);
		}

		public void TDelete(Comment item)
		{
			throw new NotImplementedException();
		}

		public Comment TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> TGetDestinationByID(int id)
		{
			return _commentDal.GetListByFilter(x => x.DestinationID == id);
		}
		public List<Comment> TGetList()
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Comment item)
		{
			throw new NotImplementedException();
		}
	}
}
