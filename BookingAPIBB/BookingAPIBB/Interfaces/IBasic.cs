namespace BookingAPIBB.Interfaces
{
    public interface IBasic<K,T>
    {
        ICollection<K> GetAll();
        K Get(T id);
        K Add(K item);
        
        K Delete(T id);
    }
}
