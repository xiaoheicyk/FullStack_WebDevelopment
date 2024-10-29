using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ApplicationCore.Contracts.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<int> InsertAsync(T entity);  
        Task<int> UpdateAsync(T entity);  
        Task<int> DeleteAsync(int id);   
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);     
        Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null); 
    }
}