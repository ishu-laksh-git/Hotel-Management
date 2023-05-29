namespace HotelsAPI.Interfaces
{
    public interface IBasic<T,K>
    {
        T Add(T item);
        ICollection<T> GetAll();
        T Delete(T item);
        T Update(T item);
        T Get(K id);
    }
}
