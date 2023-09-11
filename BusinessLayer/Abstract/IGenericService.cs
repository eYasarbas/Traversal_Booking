using System.Linq.Expressions;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void TAdd(T item);
        void TDelete(T item);
        void TUpdate(T item);

        List<T> TGetList();

        T TGetById(int id);
        List<T> GetByFilter(Expression<Func<T, bool>> filter);
    }
}
