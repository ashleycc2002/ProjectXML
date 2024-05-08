using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer.BLL.Customers
{
     public interface ICityCommandService<T> where T: class
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
        IEnumerable<T> country { get; }
        IList<T> GetAll();

    }
}
