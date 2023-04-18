namespace WpfWorkshop5.Repository
{
    public interface IRepository<T> where T : class
    {
        void Create(T item);
        IEnumerable<T> ReadAll();
    }
}