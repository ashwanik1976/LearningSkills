using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstWebAPI.Models
{
    public interface IEmployeeRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Employee Get(string code);
        Employee Add(T item);
        void Remove(int id);
        bool Update(T item);
    }
}
