using System.Linq.Expressions;

namespace ApplicationCore.Contracts.Repositories;

public interface IRespository<T> where T : class
{
    Task<int> InsertAsync(T entity);
    
    Task<int> UpdateAsync(T entity);
    
    Task<int> DeleteAsync(T entity);
    
    Task<IEnumerator<T>> GetAllAsync();
    
    Task<T> GetByIdAsync(int id);
    
    Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null);
}