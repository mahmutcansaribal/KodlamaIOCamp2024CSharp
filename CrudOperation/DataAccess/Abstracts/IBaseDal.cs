using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudOperation.DataAccess.Abstracts
{
    public interface IBaseDal<T> where T : class
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        List<T> GetAll();
    }
}
