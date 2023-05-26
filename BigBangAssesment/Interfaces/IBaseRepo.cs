namespace BigBangAssesment.Interfaces
{
    public interface IBaseRepo<K,T>
    {
        T add(T item);
        T get(K Key);
    }
}
