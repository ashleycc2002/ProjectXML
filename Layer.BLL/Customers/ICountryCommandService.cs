namespace Layer.BLL.Customers
{
    public interface ICountryCommandService<T> where T : class
    {

        void Add(T entity);
        void Add(params T[] items);
        void Update(T entity);
        void Update(params T[] items);
        void Delete(T entity);
        void Delete(params T[] items);
        T GetEntityById(int id);
        T GetEntityByName(string name);
        IQueryable<T> GetAllList(bool intactive);
        IList<T> GetEntity();
        IEnumerable <T> country {get;}
        IList<T> GetAll();    

    }
}
