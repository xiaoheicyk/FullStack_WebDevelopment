using ApplicationCore.Contracts.Repositories;
using ApplicationCore.Entities;
using Infrastruture.Data;
using Infrastruture.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories;

public class CastRepository:BaseRepository<Cast>,ICastRepository
{
    
    private readonly MovieShopDbContext _dbContext;

    public CastRepository(MovieShopDbContext dbContext) : base(dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Cast> GetByIdAsync(int id)
    {
        return _dbContext.Casts.FirstOrDefault(c=>c.Id == id);
    }

    public async Task<IEnumerable<Cast>> GetAllAsync()
    {
        return await _dbContext.Casts.ToListAsync();
    }
}