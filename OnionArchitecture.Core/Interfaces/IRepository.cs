using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnionArchitecture.Core.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        void Add(T entity);
        void Update(T entity);
        Task Delete(int id);
    }
}
