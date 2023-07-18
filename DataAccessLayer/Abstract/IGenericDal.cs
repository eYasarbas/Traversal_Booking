namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T>
    {
        void Insert(T item);
        void Delete(T item);

        void Update(T item);
        List<T> GetList();
        T GetByID(int id);
    }
}
