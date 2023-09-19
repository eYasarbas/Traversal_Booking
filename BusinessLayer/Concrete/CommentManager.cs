using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System.Linq.Expressions;

namespace BusinessLayer.Concrete;

public class CommentManager : ICommentService
{
    private readonly ICommentDal _commentDal;

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
        _commentDal.Delete(item);
    }

    public Comment TGetById(int id)
    {
        return _commentDal.GetByID(id);
    }

    public List<Comment> GetByFilter(Expression<Func<Comment, bool>> filter)
    {
        throw new NotImplementedException();
    }

    public List<Comment> TGetDestinationByID(int id)
    {
        return _commentDal.GetListByFilter(x => x.DestinationID == id);
    }

    public List<Comment> TGetListCommentsWithDestination()
    {
        return _commentDal.GetListCommentsWithDestination();
    }

    public List<Comment> TGetList()
    {
        return _commentDal.GetList();
    }

    public void TUpdate(Comment item)
    {
        throw new NotImplementedException();
    }
}