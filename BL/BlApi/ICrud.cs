
namespace BlApi
{
    public interface Icrud<T>
    {
        int Create(T item);
        T Get(int id);
        T Get(Func<T, bool> filter);
        IEnumerable<T> GetAll(Func<T, bool> filter = null);
        void Update(T item);
        void Delete(int id);
    }
}
