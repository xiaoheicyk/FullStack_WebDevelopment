using System.Linq.Expressions;
using ApplicationCore.Contracts.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class BaseRepository<T>:IRespository<T> where T:class 
{
    private readonly MovieShopDbContext _context;

    public BaseRepository(MovieShopDbContext context)
    {
        _context = context;
    }
    
    public async Task<int> InsertAsync(T entity)
    {
        await _context.Set<T>().AddAsync(entity);
        return await _context.SaveChangesAsync();
    }

    public async Task<int> UpdateAsync(T entity)
    {
        _context.Entry(entity).State = EntityState.Modified;
        return await _context.SaveChangesAsync();
    }

    public async Task<int> DeleteAsync(int id)
    {
        var entityEntry = await GetByIdAsync(id);
        _context.Set<T>().Remove(entityEntry);
        return await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id) ?? throw new InvalidOperationException();
    }

    public Task<int> GetCountAsync(Expression<Func<T, bool>> filter = null)
    {
        throw new NotImplementedException();
    }
}