using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Managment.Application.Presistence.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> Get(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<T> Delete(T item);
    }
}
