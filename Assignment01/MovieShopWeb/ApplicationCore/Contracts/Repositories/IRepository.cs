using System.Linq.Expressions;

namespace ApplicationCore.Contracts.Repositories;

public interface IRepository<T> where T : class
{
    int Insert(T entity);
    int Update(T entity);
    int Delete(int id);
    IEnumerable<T> GetAll();
    T GetById(int id);
    int GetCount(Expression<Func<T, bool>> filter = null);
    
}