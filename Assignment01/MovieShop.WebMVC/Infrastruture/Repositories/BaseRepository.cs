using System.Linq.Expressions;
using ApplicationCore.Contracts.Repositories;
using Infrastruture.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastruture.Repositories;

public class BaseRepository<T>:IRepository<T> where T : class
{
    private readonly MovieShopDbContext _context;

    public BaseRepository(MovieShopDbContext c)
    {
        _context = c;
    }
    public int Insert(T entity)
    {
        _context.Set<T>().Add(entity);
        return _context.SaveChanges();
    }

    public int Update(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        return _context.SaveChanges();
    }

    public int Delete(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            _context.Set<T>().Remove(entity);
            return _context.SaveChanges();
        }

        return 0;
    }

    public IEnumerable<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }

    public T GetById(int id)
    {
        return _context.Set<T>().Find(id);
    }

    public int GetCount(Expression<Func<T, bool>> filter)
    {
        if (filter != null)
        {
            return _context.Set<T>().Count(filter);
        }
        return _context.Set<T>().Count();
    }
}