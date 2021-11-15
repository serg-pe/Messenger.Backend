using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messenger.Application.Common.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task CreateAsync(T entity);
        public Task<IReadOnlyCollection<T>> GetAllAsync();
        public Task<T> GetByIdAsync(string id);
        public Task UpdateAsync(T entity);
        public Task DeleteAsync(T entity);
    }
}
